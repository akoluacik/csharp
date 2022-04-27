# What is LinqQueries?

LinqQueries is a way to conduct database operations in C#, without writing any SQL commands. To perform a linqquery, first of all, you need connect the database by the command below:

```CS
using(var db = new YourContextClassName)
{
    // do operations.
}
```
**In the codes below, it is assumed that you have already created your entity classes, and for this example, it is *Product*. In addition, your context class has a propery whose datatype is this entity class, and it is best practice to name it as plural form of entity class. In this example, name of my entity class is Product and it defined as:**

```CS
public class Product
{
    public int ProductId { get; set; }

    [MaxLength(100)]
    [Required] // default value of strings is null, we therefore ensure name to have a value
    public string Name { get; set; }

    public decimal Price { get; set; } // decimal? means can be nullable, decimal values have default value as null.
    
}
```
**And my context class is:**
```CS
public class ShopContext: DbContext
    {
        public DbSet<Product> Products { get; set; } // entity classes
        public DbSet<Category> Categories { get; set; }

        public static readonly ILoggerFactory MyLoggerFactory
    = LoggerFactory.Create(builder => { builder.AddConsole(); });
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseLoggerFactory(MyLoggerFactory) // to see the actual MySql query.
            .UseMySQL("server=localhost;database=shopapp2;user=root;password=");
        }
        
    }
```

# 1. Adding a record

If you want to add a product
```CS
public void AddProduct(Product product)
{
    using(var db = new YourContextClassName)
    {
        db.Products.Add(product); // executes the query
        db.SaveChanges(); // saves the changes   
    }
}
```

If *db.SaveChanges();* were not executed, the query actually was executed, but there would be no change on database.

If you want to add multiple products simultaneously,
```CS
public void AddProduct(List<Product> products)
{
    using(var db = new YourContextClassName)
    {
        db.Products.AddRange(products); // executes the query
        db.SaveChanges(); // saves the changes   
    }
}
```

# 2. Updating a record

It is about the same as adding a product.

```CS
public void UpdateProduct(int id) // assume we search the product by id
{
    using(var db = new YourContextClassName)
    {
        var product = db
        .Products
        .Select(p => p.ProductId == id)
        .FirstOrDefault();
        
        if(product != null)
        {
            product.Price *= 1.2m;
        }

        db.SaveChanges(); // saves the changes   
    }
}
```
In the code above, *FirstOrDefault()* method returns **null** if the specified record does not present.

**m** denotes decimal number, and if you forget putting it, you will get an error.

We do not have to select a record to update it:
```CS
public void UpdateProduct(int id) // assume we search the product by id
{
    using(var db = new YourContextClassName)
    {
        var entity = new Product(){Id = id}; // creating an object. 
        db.Products.Attach(entity);
        entity.Price *= 1.2m;
        db.SaveChanges(); // saves the changes   
    }
}
```
We can use *built-in* *Update()* method to update a record:
```CS
public void UpdateProduct(int id) // assume we search the product by id
{
    using(var db = new YourContextClassName)
    {
        var p = db.Products.Where(p => p.ProductId==id).FirstOrDefault();
        if(p != null)
        {
            p.Price *= 1.2m;
            db.Products.Update(p);
            db.SaveChanges();
        }
    }
}
```
# 3. Getting a record

You can search the record by its id, name. What's more, you can search a record if it contains given string. We are going to be implementing all situations. Let's get started:

 a. Getting all products: This is fairly easy:

 ```CS
    public void GetAllProducts()
    {
        using(var db = new YourContextClassName)
        {
            var products = db.Products.ToList();
        }
    }
 ```
 Here, *ToList()* methods executes the corresponding query.
 
 b. Getting specific product by its name:
 ```CS
    public void getProductsByName(string name)
    {
        using(var db = new YourContextClassName)
        {
            var products = db
            .Products.
            .Select(p=>p.Name.ToLower().Contains(name.ToLower()))
            .ToList();
        }
    }
 ```

 Here, you can either use *ToList()*, if you want to select all products, or *FirstOrDefault()* if you want to select only the first one. But not forget to control if it is **null**.
 
 Using the same analogy, you can create a function which picks the record based on id value. However, most probably id column is *primary key* in your database and therefore you will have only one record after the selection. So you better use *FirstOrDefault()* rather than *ToList()*. Otherwise, you need to use a loop.
 
 If we want to show only specific column, we can easily do this in *Console.WriteLine()*. However, we can select the columns which we want to work with:

 ```CS
 using(var db = new YourContextClassName)
 {
     var products = db
     .Products
     .Select(p =>
     new 
     {
        p.Name,
        p.Price
     })
.ToList();
 }
 ```
 Here we select only two columns, and each element of product list will not have *ProductId* property.

# 4. Deleting Record
```CS
    public void DeleteRecord(int id)
    {
        using(var db = new YourContextClassName)
        {
            
            var product = db.Products.FirstOrDefault(p=>p.ProductId == id);
            db.Remove(p) // or db.Products.Remove(p)
            db.SaveChanges();
        }
    }
 ```

The other way is the same as we did in updating part. When we don't want to pick records, we will use this way:

```CS
    public void DeleteRecord(int id)
    {
        using(var db = new YourContextClassName)
        {
            var product = new Product(){ProductId = id};
            db.Products.Remove(p);
            db.SaveChanges();
        }
    }
```

***

### Data Seeding
This a method to add test records to our database. It is useful when we need to remove database because we can save the records and use it in the database will be created.

```CS
public class DataSeeding
{
    public void Seed(DbContext YourContextInstanceName)
    {
        if(context.Database.GetPendingMigrations().Count == 0)
        {
            if(context is YourContextClassName)
            {
                ShopContext _context = context as YourContextClassName;
                if(_context.Products.Count() == 0)
                {
                   _context.Products.AddRange(Products);
                }

                if(_context.Categories.Count() == 0)
                {
                    _context.Categories.AddRange(Categories);
                }
            }
        }
    }

    private static Product[] Products = {
        new Product(){Name = "p1", Price=1},
        new Product(){Name = "p2", Price=2},
        new Product(){Name = "p3", Price=3},
        new Product(){Name = "p4", Price=4},
        new Product(){Name = "p5", Price=5},
        new Product(){Name = "p6", Price=6}
    };

    private static Category[] Categories = {
        new Category(){Name = "c1"},
        new Category(){Name = "c2"},
        new Category(){Name = "c3"},
        new Category(){Name = "c4"},
        new Category(){Name = "c5"},
        new Category(){Name = "c6"}
    };

}
```

Once we create an instance from **DataSeed** class, and invoke **AddProduct** and **AddCategory** methods, we see that our tables corresponding tables are filled, if they are **empty**.
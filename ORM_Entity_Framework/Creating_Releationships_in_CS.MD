# Creating Releationships with ORM Entity Framework<br>
 ORM entity framework allows us to create releationships between tables. All kind of releationships can be created, and we can add data to tables by not using passing any Id parameters.

 1.  ## One to Many Releationship
 Below, there's a code to create one-to-many releationship. We know that a UserId occurs once in a database, but each user may have multiple addresses. Here we'll illustrate this condition.

```CS
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    public class ShopContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;port=3306;database=shop;user=root;password=admin");
        }
    }

    public User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Address>Addresses { get; set; } // Navigaton property
    }

    public Addresses
    {
        public int Id;
        public string Fullname;
        public string Title;
        public string Body;
        public User User; // Navigaton property
        public int UserId; // foreign key
    }

    class Program
    {
        public static void Main()
        {
            // InsertUser();
            // InsertAddresses();

            // Adding Address to a specific user by using navigation property
            
            using(var db = new ShopContext())
            {
                var user = db.Users.FirstOrDefault(i => i.Name == "johndoe1");
                
                if(user != null)
                {
                    User.Addresses.Add(new Address(){Fullname="John Doe", Title="Home Address 2", Body="Colorado", UserId = 1});
                }
                db.SaveChanges();
            }
        }

        public static void InsertUsers()
        {
            var users = new List<User>()
            {
                new User(){Name = "johndoe1", Email="johndoe1@example.com"},
                new User(){Name = "johndoe2", Email="johndoe2@example.com"},
                new User(){Name = "johndoe3", Email="johndoe3@example.com"},
                new User(){Name = "johndoe4", Email="johndoe4@example.com"},
                new User(){Name = "johndoe5", Email="johndoe5@example.com"}
            };

            using (var db = new ShopContext())
            {
                db.Users.AddRange(users);
                db.SaveChanges();
            }
        }

        public static void InsertAddresses()
        {
            var addresses = new List<Address>()
            {
                new Address(){Fullname="John Doe", Title="Home Address", Body="Hawana", UserId = 1},
                new Address(){Fullname="John Doe", Title="Job Address", Body="Maldivs", UserId = 2},
                new Address(){Fullname="John Doe", Title="Job Address", Body="Toronto", UserId = 4},
                new Address(){Fullname="John Doe", Title="Home Address", Body="Pompei", UserId = 3},
                new Address(){Fullname="John Doe", Title="Home Address", Body="Hawana", UserId = 1},
                new Address(){Fullname="John Doe", Title="Job Address", Body="Maldivs", UserId = 2},
                new Address(){Fullname="John Doe", Title="Job Address", Body="Toronto", UserId = 4},
                new Address(){Fullname="John Doe", Title="Home Address", Body="Chicago", UserId = 5}
            };

            using (var db = new ShopContext())
            {
                db.Addresses.AddRange(addresses);
                db.SaveChanges();
            }
        }
    }
```

If you **run** this code, you'll face an error, because we haven't initialize *Addresses* in the users list yet, we only create its reference, we therefore need to initialize it. We can handle this with two different ways, but they are about the same.
First, create a *constructor*, and initialize it here:
```CS
    public class User
    {
        public User()
        {
            this.Addresses = new List<Address>();
        }
    }
```

or Second, you can initialize this for only specific customers as:
```CS
    using (var db = new ShopContext())
    {
        users.Addresses = new List<Address>();
        db.Addresses.AddRange(addresses);
        db.SaveChanges();
    }
```
In addition, as mentioned, we access the data of customer from its reference, we didn't use any information at all.


2. ## One-to-Many Releationship

```CS
    public class User
    {
        public User()
        {
            // if you don't do this, you'll get null reference error.
            // You can handle this by creating new Address list in if block.
            this.Addresses = new List<Address>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Customer Customer { get; set; } // Navigation property
        public List<Address> Addresses { get; set; } // One user has lots of addresses. Navigation property
    }

    public class Customer
    {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public User User { get; set; }
        public int UserId { get; set; } // foreign key, unique
    }
```

The above establishes a one-to-one relation. In User class, we add Customer object, and add User object and UserId and this Id must be unique.

## 2.Many-to-Many Relationship
In order to establish many-to-many relationship, we need to create a table socalled **junction** table, which contains the Ids and references of all tables which are being trying to establish a connection.

```CS

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<ProductCategory> ProductCategories { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<ProductCategory> ProductCategories { get; set; }
}

public class ProductCategory // junction table
{
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
```

Normally, we have to add our methods affect database to context class, but we don't need to add ProductCategory class there. Instead, we have to override a method named *OnModelCreating()*.

```CS
public class ShopContext:DbContext
{
    // only mentioned-method will being implemented. Go above to see others.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductCategory>().HasKey(t => new {t.ProductId, t.CategoryId});
    }
}
```

What we are doing above is we are selecting the entity we want to change, which is now ProductCategory, and then create a key for the entity which is formed by combination of two different *Id*s. With this statement, we ensure that the same ProductId, CategoryId pairs will not appear twice in the table. We can add **different attributes to columns**, like *NOT NULL*. For more information about these, visit [documentation web site](https://docs.microsoft.com/en-us/ef/core/modeling// "Microsoft Docs")


From this point, we need to add 2 more statement to indicate the Product and Category have many-to-many relationship.

```cs
modelBuilder.Entity<ProductCategory>()
            .HasOne(pc=>pc.Product)// pc=ProductCategory
            .WithMany(c=>c.ProductCategories)
            .HasForeignKey(pc=>pc.ProductId);
```

In ProductCategory table, there are only one product for one category. So we pass that to HasOne method as argument, after that, we establish the many-to-many relationship, note that we do this with a List object. Finally, emphasize the foreign key of the table.
Once you do this for Category, and create the migration, you'll end up with a database whose Product and Category tables have many-to-many relationship.
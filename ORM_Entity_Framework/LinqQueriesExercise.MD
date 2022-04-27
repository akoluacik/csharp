1. Retrieve all customers from northwind db using linq queries
```CS
var customers = db.Customers.ToList();
foreach (var c in customers)
{
    Console.WriteLine(c.FirstName + " " + c.LastName);
}

```

2. Retrieve only first and last names of all customers
```CS
var customers = db.Customers.Select(c => new { ananymous datatype
    c.FirstName,
    c.LastName
});
foreach (var c in customers)
{
    Console.WriteLine(c.FirstName + " " + c.LastName);
}
```

3. Orders the customers who are in New York
```CS
var customers = db.Customers
.Where(c => c.City == "New York")
.Select(c => new {c.FirstName, c.LastName})
.ToList();
foreach (var c in customers)
{
    Console.WriteLine(c.FirstName + " " + c.LastName);   
}
```
What if we had written Select before Where. Then we'd get an error because at first, we only retrieve the columns, FirstName and LastName, so the column City wasn't present there. To tackle this, add City column inside Select method.

4.Retrieve the product names whose category is Beverage.
```CS
var productNames = db.Products
                     .Where(p=>p.Category=="Beverages")
                     .Select(p=>p.ProductName)
                     .ToList();
foreach (var name in productNames)
{
    Console.WriteLine(name);
}
```

5. Grab the five product added the latest.
```CS
var products = db.Products.OrderBy(p=>p.Id).Take(5);
foreach (var p in products)
{
    Console.WriteLine(p.ProductName);
}
```

6. Print name, price of products whose price in between 10 to 30.
```CS
var products = db.Products
                 .Where(p=>(p.ListPrice >= 10 && p.ListPrice <= 30))
                 .Select(p => new {p.ProductName, p.ListPrice})
                 .ToList();
foreach (var p in products)
{
    Console.WriteLine($"ProductName:{p.ProductName} ListPrice:{p.ListPrice}" );
}
```

7. Average price of products inside Beverages Category
```CS
var products = db.Products
                    .Where(p => p.Category == "Beverages")
                    .Select(p => p.ListPrice)
                    .ToList();
Console.WriteLine(products.Average());
```
*Second way*
```CS
var products = db.Products
                    .Where(p => p.Category == "Beverages")
                    .Average(p => p.ListPrice)
Console.WriteLine(products);
```

//8. How many products are there inside Beverages Category
```CS
var count = db.Products
                .Where(p => p.Category == "Beverages")
                .Count();
Console.WriteLine(count);
```
*The best way:*
```CS
var count = db.Products.Count(p => p.Category == "Beverages");
Console.WriteLine(count);
```

9. Total price of the products inside "Beverages" and "Condiments" Category
```CS
var sum = db.Products
            .Where(p => p.Category == "Beverages" || p.Category == "Condiments")
            .Sum(p => p.ListPrice);
Console.WriteLine(sum);
```

//10. Retrieve the products which contains Tea.
```CS
var products = db.Products
                    .Where(p => p.ProductName.Contains("Tea") || p.Description.Contains("Tea"))
                    .Select(p=>p.ProductName);
foreach (var p in products)
{
    Console.WriteLine(p);
}
```
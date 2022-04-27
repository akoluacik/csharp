# What's ORM Entity Framework and How It Works?

## What is ORM
ORM, Object Relational Mapping, allows us to use Database without using database queries. It contains some methods that realize database queries, related to the database we are using, behalf of us.

## What is Entity
It is simply (a) class(es) that hold(s) value of columns of the rows we retrieve from database. 

## What is Context
Basically, it is again a class which holds our *entities*, and also responsible for communicating our database. Its properties are assumed to be *DbSet* datatype, and it's best practice to give these names as plural version of each entity classes. In addition, the class has to be inherited from *DbContext* class inside *Microsoft.EntityFrameworkCore* library.

Let's create a simple to unite these concepts.

```CS
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ORM_Entity_Framework
{
    public class ShopContext: DbContext // Context class
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // method responsible for communicatin db.
        {
            // you can use different databases, like MsSql, by using UseMsSql
            // fill the required information below according to 
            // database, by removing question marks(?).
            
            optionsBuilder.UseMySQL(
                "server=;port=;database=?;user=?;password=?"
            );
        }
    }

    // Entity classes
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set;}
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set }
    }
}
```

After this point, you need to visit **[this](https://docs.microsoft.com/en-us/ef/core/get-started/overview/install)** to install Entity Framework requirements, and **[this](https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli)** to create database, migrations, and usage of queries inside your program.


# Updating A Table by Using Entity Framework
We need to create a **migration** to reach and perform operations by using *Entity Framework*. Once we do this, we see that there is an additional table holds the migrations that we've created. We can create multiple migrations, and we do this when *we need to update our table*.

Our schema has three table, one is migration, the others are category and product tables. We see that product table has no column named category. When we want to add this, we need to write the code below to terminal:

```sh
    dotnet ef migrations add addColumnProductCategoryId
```

It is a best practice to write this as this format
```bash
    dotnet ef migrations add addColumnTableNamePropertyName
```

When we run this command, we see that there is an another cs file called *addColumnProductCategoryId*, which has two methods, *up* and *down*. *Up* method responsible to create the table while *down* deletes the table. And the migration is also added to migrations table in the database.

**To apply these commands**, we need to write another command script:
```
    dotnet ef database update
```

*database* command responsible for database operations. Once we run the command above, our database is updated.

If you want to **delete the last change** from the database, you need update your database with previous update name.
```
    dotnet ef migrations add addColumnTableNamePropertyName
```

To **delete** the *last migration*:
```
    dotnet ef migraitons remove
```

If you want to **remove** the database completely, you need to use
```
    dotnet ef update 0
```
so you can go the very first step.

If you want to delete a database from server,
```
    dotnet ef database drop --force
```
removes the database from the server even if **a connection to it is present**.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ORM_Entity_Framework.Data.EfCore;

namespace ORM_Entity_Framework
{
    public class CustomerDemo
    {
        public CustomerDemo()
        {
            orders = new List<OrderDemo>();
        }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int OrderCount { get; set; }
        public List<OrderDemo> orders { get; set; }
    }

    public class OrderDemo
    {
        public int OrderId { get; set; }
        public decimal Total { get; set; }
    }

    public class LinqQueriesWithMultipleTables
    {
        public void test()
        {
            using (var db = new NorthwindContext())
            {
                var customers = db.Customers
                                .Where(i => i.Orders.Any())
                                .Select(i => new CustomerDemo
                                {
                                    CustomerId = i.Id,
                                    Name = i.FirstName,
                                    OrderCount = i.Orders.Count(),
                                    orders = i.Orders.Select(o => new OrderDemo
                                    {
                                        OrderId = o.Id,
                                        Total = (decimal)o.OrderDetails.Sum(od => od.Quantity * od.UnitPrice)
                                    }).ToList() // orders is a list, this is required.
                                })
                                .OrderBy(i=>i.OrderCount)
                                .ToList();
                foreach (var customer in customers)
                {
                    Console.WriteLine($"id: {customer.CustomerId} name:{customer.Name} count:{customer.OrderCount}");
                    Console.WriteLine("*****************************************");
                    foreach (var order in customer.orders)
                    {
                        Console.WriteLine($"order id:{order.OrderId} total:{order.Total}");
                    }
                    Console.WriteLine("*****************************************");
                }
            }
        }
    }
}
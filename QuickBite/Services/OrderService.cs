using QuickBite.Context;
using QuickBite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBite.Services
{
    public class OrderService
    {
        public void AddOrder(Order order)
        {
            using var context = new QuickBiteContext();
            context.Orders.Add(order);
            context.SaveChanges();
        }
    }
}

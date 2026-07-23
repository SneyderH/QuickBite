using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBite.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string NameProduct { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Category { get; set; } = string.Empty;

        public List<OrderItem> OrderItems { get; set; } = new();
    }
}

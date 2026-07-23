using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBite.Models
{
    public enum TableStatus
    {
        Available = 0,
        Occupied = 1,
        Reserved = 2
    }

    public class Table
    {
        public int Id { get; set; }
        public TableStatus Status { get; set; } = TableStatus.Available;

        public List<Order> Orders { get; set; } = new(); // Relationship with Order class
    }
}

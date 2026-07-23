using QuickBite.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBite.Models
{
    public enum OrderStatus
    {
        Pending = 0,
        InProgress = 1,
        Completed = 2,
        Cancelled = 3,
        Paid = 4
    }

    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;

        public int TableId { get; set; }
        public Table? Table { get; set; }

        public int WaiterId { get; set; }
        public Users? Waiter { get; set; }

        public List<OrderItem> Items { get; set; } = new();
    }
}

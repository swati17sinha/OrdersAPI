using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersAPI.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public double OrderAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
    }
}

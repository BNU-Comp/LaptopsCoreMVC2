using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopsCoreMVC.Models
{
    /// <summary>
    /// Luke
    /// </summary>
    public class Order
    {

        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime DatePurchased { get; set; }
        public int OrderStatus { get; set; }
        public DateTime DateDelivered { get; set; }

    }
}

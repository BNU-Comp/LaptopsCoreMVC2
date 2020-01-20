using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopsCoreMVC.Models
{
    public class PaymentCard
    {

        public int PaymentCardID { get; set; }

        public string Type { get; set; }
        public int CustomerID { get; set; }
        public string ExpiryDate {get;set;}

    }
}

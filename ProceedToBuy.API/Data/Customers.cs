using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProceedToBuy.API.Data
{
    public class Customers
    {
       
        public int Id { get; set; } 
        public string CustomerName { get; set; }
        public double DeliveryCharge { get; set; }
    }
}

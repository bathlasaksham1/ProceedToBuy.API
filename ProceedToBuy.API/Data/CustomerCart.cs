using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProceedToBuy.API.Data
{
    public class CustomerCart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public long Zipcode { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int Quantity { get; set; }
        public Customers cust { get; set; }


    }
}

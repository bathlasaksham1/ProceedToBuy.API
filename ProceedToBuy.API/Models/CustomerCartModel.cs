using ProceedToBuy.API.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProceedToBuy.API.Models
{
    public class CustomerCartModel
    {
        [Required][Key]
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public long Zipcode { get; set; }
        [Required]
        public DateTime  DeliveryDate { get; set; }
        [Required]
        public Customers cust { get; set; }
        [Required]
        public int Quantity { get; set; }


    }
}

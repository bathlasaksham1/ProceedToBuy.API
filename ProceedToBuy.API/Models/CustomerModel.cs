using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProceedToBuy.API.Models
{
    public class CustomerModel
    {
        [Key][Required]
        public int Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public double  DeliveryCharge { get; set; }

    }
}

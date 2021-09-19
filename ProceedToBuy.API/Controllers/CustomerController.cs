using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProceedToBuy.API.Data;
using ProceedToBuy.API.Models;
using ProceedToBuy.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProceedToBuy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
      
        //yeh post karegaaa dataa ko 
        [HttpPost("{CustomerId}")]
        public async Task<IActionResult> addProductToCart( [FromRoute]int CustomerId,[FromBody] CustomerCartModel customercartmodel)
        {
            var Id = await _customerRepository.addProductToCartAsync(CustomerId,customercartmodel);
            //return CreatedAtAction(nameof(GetProductById), new { id = Id, controller = "Customers" }, Id);
            return Ok(Id);
        }

        [HttpPost("{CustomerId}/{ProductId}")]
        public async Task<IActionResult> addWishList(int CustomerId, int ProductId)
        {
            await _customerRepository.addProductToWishListAsync(CustomerId, ProductId);
           // return CreatedAtAction(nameof(GetProductById), new { id = Id, controller = "Customers" }, Id);
            return Ok();
        }
    }
}

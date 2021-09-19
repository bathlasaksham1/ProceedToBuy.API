using Microsoft.EntityFrameworkCore;
using ProceedToBuy.API.Data;
using ProceedToBuy.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProceedToBuy.API.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDbContext _context;
        public CustomerRepository(CustomerDbContext context)
        {
            _context = context;
        }
        public async Task<CustomerModel> GetProductByIdAsync(int ProductId)
        {

            var records = await _context.Customers.Where(x => x.Id == ProductId).Select(x => new CustomerModel
            {
                Id = x.Id,
                CustomerName = x.CustomerName,
                DeliveryCharge = x.DeliveryCharge,

            }).FirstOrDefaultAsync();
            return records;

        }
        public async Task<CustomerCart> addProductToCartAsync(int CustomerId, CustomerCartModel customercartmodel)
        {
            //Concert ProductModel to Products which is present in Data Folder

            var customer = _context.Customers.Find(CustomerId);

            var sample = new CustomerCart()
            {
                ProductId = customercartmodel.ProductId,
                Zipcode = customercartmodel.Zipcode,
                DeliveryDate = customercartmodel.DeliveryDate,
                cust = customer
            };


            _context.CustomerCarts.Add(sample);
            await _context.SaveChangesAsync();
            return sample;
        }
        

        public async Task addProductToWishListAsync(int CustomerId, int ProductId)
        {
            var product = _context.CustomerCarts.Where(x => x.ProductId == ProductId);
            var sample = new CustomerWishlist()
            {
                Id = CustomerId,
                ProductId = ProductId,
                Quantity = 1,
                DateAddedToWishlist = DateTime.Now
            };
            _context.CustomerWishlists.Add(sample);
            await _context.SaveChangesAsync();
            

        }


    }

}


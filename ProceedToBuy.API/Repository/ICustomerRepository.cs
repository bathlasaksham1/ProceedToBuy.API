using ProceedToBuy.API.Data;
using ProceedToBuy.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProceedToBuy.API.Repository
{
   public interface ICustomerRepository
    {
        Task<CustomerCart> addProductToCartAsync(int CustomerId, CustomerCartModel customercartmodel);
        //Task<CustomerModel> GetProductByIdAsync(int ProductId);

        Task addProductToWishListAsync(int CustomerId, int ProductId);

    }
}

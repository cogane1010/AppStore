using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppStore.Core.Models;

namespace AppStore.Services.Interfaces
{
    public interface IProductService
    {
        Task<bool> CreateProduct(ProductDetails productDetails);

        Task<IEnumerable<ProductDetails>> GetAllProducts();

        Task<ProductDetails> GetProductById(int productId);

        Task<bool> UpdateProduct(ProductDetails productDetails);

        Task<bool> DeleteProduct(int productId);
    }
}

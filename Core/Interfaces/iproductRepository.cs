using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface iproductRepository
    {
        Task<Product> getProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}
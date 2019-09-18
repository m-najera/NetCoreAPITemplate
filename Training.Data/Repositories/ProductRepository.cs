using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Training.API.Contracts;

namespace Training.Data.Repositories
{
    public class ProductRepository : IProductsRepository
    {
        private readonly StoreContext _StoreContext;
        public ProductRepository(StoreContext storeContext)
        {
            _StoreContext = storeContext;
        }
        public async Task<List<DTO.Product>> GetAll()
        {
            var products = await _StoreContext.Products.ToListAsync();
            var productsDTOList = products.Select(x => x.ToDTO()).ToList();
            return productsDTOList;
        }
    }
}

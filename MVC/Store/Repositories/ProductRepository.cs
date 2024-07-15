using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext contex) : base(contex)
        {
        }

        public IQueryable<Product> GetAllProducts(bool trackChanges) =>FindAll(trackChanges);

    }
}
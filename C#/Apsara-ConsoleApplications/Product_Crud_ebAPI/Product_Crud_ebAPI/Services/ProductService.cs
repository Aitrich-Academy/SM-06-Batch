using Product_Crud_ebAPI.Models;
using Product_Crud_ebAPI.Repository;

namespace Product_Crud_ebAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Product> GetAll()
        {
            return _repo.GetAll();
        }

        public Product GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Add(Product product)
        {
            _repo.Add(product);
        }

        public void Update(Product product)
        {
            _repo.Update(product);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }
    }
}


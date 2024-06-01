using MVC_CRUD.Models;

namespace MVC_CRUD.IServices
{
    public interface IProductServices
    {
        List<Product> GetAll();
        Product GetById(string id);
        bool CreateProduct(Product product);
        bool UpdateProduct(Product product);    
        bool DeleteProduct(string id);
    }
}

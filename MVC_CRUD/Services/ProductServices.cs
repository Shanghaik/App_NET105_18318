using Microsoft.AspNetCore.Mvc;
using MVC_CRUD.IServices;
using MVC_CRUD.Models;
using Newtonsoft.Json;

namespace MVC_CRUD.Services
{
    public class ProductServices : IProductServices
    {
        HttpClient _httpClient;
        public ProductServices()
        {
            _httpClient = new HttpClient();
        }
        public bool CreateProduct(Product product)
        {
            // Tạo requetsURL
            string requestURL = "https://localhost:7169/product/create-product";
            var response = _httpClient.PostAsJsonAsync(requestURL, product).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public bool DeleteProduct(string id)
        {
            string requestURL = $"https://localhost:7169/product/delete-product?id={id}";
            var response = _httpClient.DeleteAsync(requestURL).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public List<Product> GetAll()
        {
            string requestURL = $"https://localhost:7169/product/get-all-product";
            var response = _httpClient.GetStringAsync(requestURL).Result;
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(response);
            return products;
        }
        public Product GetById(string id)
        {
            string requestURL = $"https://localhost:7169/product/get-by-id?id={id}";
            var response = _httpClient.GetStringAsync(requestURL).Result;
            Product product = JsonConvert.DeserializeObject<Product>(response);
            return product;
        }
        public bool UpdateProduct(Product product)
        {
            string requestURL = $"https://localhost:7169/product/update-product";
            var response = _httpClient.PutAsJsonAsync(requestURL, product).Result;
            if(response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}

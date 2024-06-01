using System.ComponentModel.DataAnnotations;

namespace CRUD_API.Models
{
    public class Product
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        public int Quantity { get; set; }

    }
}

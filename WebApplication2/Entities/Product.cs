using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Entities
{
    public class Product
    {
        [Range(1,100,ErrorMessage ="Id is required! Between 7-100")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Describe the Product")]
        public string Description { get; set; }
        [Range(1, 5000, ErrorMessage = "Price should be between 1-5000")]
        public int Price{ get; set; }
        public int Discount { get; set; }

    }
}

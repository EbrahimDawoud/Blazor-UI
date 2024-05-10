using System.ComponentModel.DataAnnotations;

namespace Demo1.Models
{
    public class Product
    {
        //[UniqueIdValidation(ErrorMessage = "u have to add a valid id")]
        public int Id { get; set; }
        [MinLength(3, ErrorMessage ="u have to add at least 3 chars")]
        [MaxLength(20, ErrorMessage = "u have to add at most 20 chars")]
        public string Name { get; set; }
        [Range(1000, 10000, ErrorMessage = "u have to add a price between 1000 and 10000")]
        public int Price { get; set; }
        //[Url(ErrorMessage = "u have to add a valid url")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "u have to add a category id")]
        public int CatId { get; set; }
    }
}

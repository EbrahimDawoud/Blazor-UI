using System.ComponentModel.DataAnnotations;

namespace Demo1.Models
{
    public class Product
    {
        [UniqueIdValidation]
        public int Id { get; set; }
        [MinLength(3, ErrorMessage ="U must enter at least 3 chars"), MaxLength(20, ErrorMessage ="u shouldn't excceed 20 chars")]
        public string Name { get; set; }
        [Range(1, 1000, ErrorMessage ="Price must be between 1 and 1000")]
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public int CatId { get; set; }
    }
}

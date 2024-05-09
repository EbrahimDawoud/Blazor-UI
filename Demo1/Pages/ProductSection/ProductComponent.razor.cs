using Demo1.Models;

namespace Demo1.Pages.ProductSection
{
    public partial class ProductComponent
    {
        public Product obj { get; set; }
        public ProductComponent()
        {
            obj = new Product();
            obj.Id = 1;
            obj.Name = "John";
            obj.Price = 17000;
            obj.ImageUrl = "Man.png";

        }
    }
}

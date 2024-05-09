using Demo1.Services;
using Microsoft.AspNetCore.Components;

namespace Demo1.Pages.ProductSection
{
    public partial class ProductsW_S_Component
    {
        public List<Product> productList = new List<Product>();
        public List<Category> categoryList = new List<Category>();
        [Inject]
        public IService<Product> ProductService { get; set; }
        [Inject]
        public IService<Category> CategoryService { get; set; }
        protected override void OnInitialized()
        {
            productList = ProductService.GetAll();
            categoryList = CategoryService.GetAll();

            base.OnInitialized();
        }
    }
}

namespace Demo1.Pages.ProductSection
{
    public partial class AllProductComponent
    {
        public int ProdId { get; set; }
        public List<Product> EmpList { get; set; }
        public Product ProdObj { get; set; }
        public bool showGrid { get; set; }
        public AllProductComponent()
        {
            EmpList = new List<Product>(){
            new Product() { Id = 1, Name = "Product1", Price=  30000, ImageUrl="https://toriavey.com/images/2011/01/TOA109_18-1.jpeg"},
            new Product() { Id = 2, Name = "Product2",Price=  20000, ImageUrl="https://toriavey.com/images/2011/01/TOA109_18-1.jpeg"},
            new Product() { Id = 3, Name = "Product3",Price=  30000, ImageUrl="https://toriavey.com/images/2011/01/TOA109_18-1.jpeg"},
            new Product() { Id = 4, Name = "Product4",  Price=  40000, ImageUrl="https://toriavey.com/images/2011/01/TOA109_18-1.jpeg"},
            new Product() { Id = 5, Name = "Product",Price=  50000, ImageUrl="https://toriavey.com/images/2011/01/TOA109_18-1.jpeg"},
        };

        }
        public void getProduct()
        {
            ProdObj = EmpList.FirstOrDefault(x => x.Id == ProdId);
            showGrid = false;

        }
        public void ShowAllProducts()
        {
            showGrid = true;
        }
    }
}

namespace Demo1.Services
{
    public class ProductService : IService<Product> 
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public ProductService()
        {

            Products.Add(new Product() { Id = 1, Name = "Product1", Price = 30000, ImageUrl = "/images/prod.jpeg", CatId=1 });
            Products.Add(new Product() { Id = 2, Name = "Product2", Price = 20000, ImageUrl = "https://toriavey.com/images/2011/01/TOA109_18-1.jpeg",  CatId = 2 });
            Products.Add(new Product() { Id = 3, Name = "Product3", Price = 30000, ImageUrl = "https://toriavey.com/images/2011/01/TOA109_18-1.jpeg",  CatId = 3 });
            Products.Add(new Product() { Id = 4, Name = "Product4",  Price=  40000, ImageUrl="https://toriavey.com/images/2011/01/TOA109_18-1.jpeg",  CatId = 1 });
            Products.Add(new Product() { Id = 5, Name = "Product",Price=  50000, ImageUrl="https://toriavey.com/images/2011/01/TOA109_18-1.jpeg",  CatId = 2 });
        
        }

        public List<Product> GetAll() 
        {
            return Products;
        }
        public Product GetById(int id) 
        {
            return Products.FirstOrDefault(e=>e.Id == id);
        }
    }
}

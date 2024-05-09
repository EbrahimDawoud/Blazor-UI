namespace Demo1.Services
{
    public class CategoryService : IService<Category> 
    {
        public List<Category> categories { get; set; } = new List<Category>();
        public CategoryService()
        {
            categories.Add(new Category() { Id=1, Name= "Cat1"});
            categories.Add(new Category() { Id=2, Name= "Cat2"});
            categories.Add(new Category() { Id=3, Name= "Cat3"});
            categories.Add(new Category() { Id=4, Name= "Cat4"});
            categories.Add(new Category() { Id=5, Name= "Cat5"});
        }

        public List<Category> GetAll() 
        {
            return categories;
        }
        public Category GetById(int id) 
        {
            return categories.FirstOrDefault(e=>e.Id == id);
        }
    }
}

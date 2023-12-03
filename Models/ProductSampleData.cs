namespace ITIproject.Models
{
    public class ProductSampleData
    {
        List<Product> products=new List<Product>();

        public ProductSampleData()
        {
            products.Add(new Product() { Id=1,Name="Iphone",Price=300,Description="affordable",Image= "Screenshot(23).png" });
            products.Add(new Product() { Id=2,Name="Iphone2",Price=3001,Description="nice",Image= "Screenshot(24).png" });
            products.Add(new Product() { Id=4,Name="Iphone3",Price=3001,Description="Very good",Image= "Screenshot(26).png" });
            products.Add(new Product() { Id=4,Name="Iphone4",Price=3003,Description="Execllent",Image= "Screenshot(27).png" });
        }
        public  List<Product> GetAll()
        {
            return products;
        }
        public Product GetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
}

using ECommerceBlazor.Models;

namespace ECommerceBlazor.Services
{
    public class ProductService : IProductService
    {
        public async Task<Product> GetProductById(int id)
        {
            await Task.Delay(100);
            return GetAllProducts().FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Tesla Model S",
                    Description = "An electric sedan with impressive range and performance.",
                    ImageUrl = "images/tesla_model_s.jpeg",
                    Price = 89999.99m,
                    Brand = "Tesla"
                },
                new Product
                {
                    Id = 2,
                    Name = "Ford Mustang Mach-E",
                    Description = "A stylish electric SUV inspired by the iconic Mustang.",
                    ImageUrl = "images/ford_mustang.jpeg",
                    Price = 59999.99m,
                    Brand = "Ford"
                },
                new Product
                {
                    Id = 3,
                    Name = "Chevrolet Corvette",
                    Description = "A high-performance sports car with a sleek design.",
                    ImageUrl = "images/chevrolet_corvette.jpeg",
                    Price = 74999.99m,
                    Brand = "Chevrolet"
                },
                new Product
                {
                    Id = 4,
                    Name = "BMW 3 Series",
                    Description = "A luxury sedan with a perfect balance of performance and comfort.",
                    ImageUrl = "images/bmw_3_series.jpeg",
                    Price = 42999.99m,
                    Brand = "BMW"
                },
                new Product
                {
                    Id = 5,
                    Name = "Audi A4",
                    Description = "A sophisticated and stylish compact luxury sedan.",
                    ImageUrl = "images/audi_a4.jpeg",
                    Price = 40999.99m,
                    Brand = "Audi"
                },
                new Product
                {
                    Id = 6,
                    Name = "Mercedes-Benz C-Class",
                    Description = "A premium sedan with advanced technology and comfort.",
                    ImageUrl = "images/mercedes_c_class.jpeg",
                    Price = 45999.99m,
                    Brand = "Mercedes-Benz"
                },
                new Product
                {
                    Id = 7,
                    Name = "Toyota Camry",
                    Description = "A reliable and efficient mid-size sedan.",
                    ImageUrl = "images/toyota_camry.jpeg",
                    Price = 25999.99m,
                    Brand = "Toyota"
                },
                new Product
                {
                    Id = 8,
                    Name = "Honda Accord",
                    Description = "A spacious and well-equipped sedan for families.",
                    ImageUrl = "images/honda_accord.jpeg",
                    Price = 24999.99m,
                    Brand = "Honda"
                },
                new Product
                {
                    Id = 9,
                    Name = "Mazda CX-5",
                    Description = "A compact SUV with sporty handling and premium features.",
                    ImageUrl = "images/mazda_cx5.jpeg",
                    Price = 28999.99m,
                    Brand = "Mazda"
                },
                new Product
                {
                    Id = 10,
                    Name = "Hyundai Tucson",
                    Description = "A stylish SUV with advanced safety and technology.",
                    ImageUrl = "images/hyundai_tucson.jpeg",
                    Price = 27999.99m,
                    Brand = "Hyundai"
                }
            };
            return products;
        }
    }
}

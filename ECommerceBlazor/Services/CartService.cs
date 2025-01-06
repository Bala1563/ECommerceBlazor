using ECommerceBlazor.Models;
using ECommerceBlazor.Pages;

namespace ECommerceBlazor.Services
{
    public class CartService
    {
        public List<Cart> cartProducts { get; set; } = new List<Cart>();

        public void AddToCart(Product product)
        {
            var currentCartProduct = GetCartProduct(product.Id);
            if (currentCartProduct == null)
            {
                cartProducts.Add(new Cart
                {
                    Product = product,
                    Id = cartProducts.Count + 1,
                    Quantity = 1,
                });
            }
            else
            {
                currentCartProduct.Quantity++;
            }
        }
        public void RemoveFromCart(Product product)
        {
            var currentCartProduct = GetCartProduct(product.Id);
            if (currentCartProduct != null)
            {
                cartProducts.Remove(currentCartProduct);
            }
        }
        public void IncrementQuantity(int productId)
        {
            var currentCartProduct = GetCartProduct(productId);
            currentCartProduct.Quantity++;
        }
        public void DecrementQuantity(int productId)
        {
            var currentCartProduct = GetCartProduct(productId);
            if(currentCartProduct.Quantity > 1)
            {
                currentCartProduct.Quantity--;
            }
            else
            {
                cartProducts.Remove(currentCartProduct);
            }
        }
        public void RemoveAll()
        {
            cartProducts.Clear();
        }
        public decimal TotalPriceOfCart()
        {
            return cartProducts.Sum(c => c.Product.Price * c.Quantity);
        }
        private Cart? GetCartProduct(int productId)
        {
            return cartProducts.FirstOrDefault(c => c.Product.Id == productId);
        }
    }
}

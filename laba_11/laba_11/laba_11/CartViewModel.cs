using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_11
{
    public class CartViewModel
    {
        public Cart Cart { get; set; }

        public CartViewModel()
        {
            Cart = new Cart();
        }

        public void AddProductToCart(string name, double price, int quantity)
        {
            var product = new Product { Name = name, Price = price, Quantity = quantity };
            Cart.AddProduct(product);
        }

        public void RemoveProductFromCart(Product product)
        {
            Cart.RemoveProduct(product);
        }
    }
}

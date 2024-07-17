using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace laba_11
{
    public class Cart
    {
        public List<Product> Products { get; set; }

        public Cart()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            foreach (Product p in Products)
            {
                if (p.Name == product.Name && p.Price == product.Price && p.Quantity == product.Quantity)
                {
                    Products.Remove(p);
                    MessageBox.Show("All Correct");
                    return;
                }
            }

            MessageBox.Show("This not");
        }
    }
}

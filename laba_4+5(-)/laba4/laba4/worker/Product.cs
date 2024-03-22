using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.worker
{
    public class Product
    {
        public Product()
        {

        }
        public Product(string pictur, string name, double price, string Descr, string? allDescr, int quantity)
        {
            PicturePath = pictur;
            Name = name;
            Price = price;
            Description = Descr;
            AllDescription = allDescr;
            Quantity = quantity;
        }

        public string? PicturePath { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public string? AllDescription { get; set; }
        public int Quantity { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.UndoRedo
{
    class Inform
    {
        public Inform()
        {
            
        }
        public Inform(string name, string price, string dick, string quantity)
        {
            this.name = name;
            this.Price = price;
            this.Dictanary = dick;
            this.Quantity = quantity;
        }
        public string? name { get; set; } = null;
        public string? Price { get; set; } = null;
        public string? Dictanary { get; set; } = null;
        public string? Quantity { get; set; } = null;

    }
}

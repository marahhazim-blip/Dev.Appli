using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGenerique
{
    internal class Produit
    {

        public string Name { get; set; }
        public int Price { get; set; }

        public Produit(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - {Price} euros";
        }
    }
}

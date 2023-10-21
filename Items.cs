using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortix
{
    internal class Items
    {
        public string Name;
        public int Price;
        public Items(string name, int price) // конструкторы краш
        {
            Name = name;
            Price = price;
        }
    }
}
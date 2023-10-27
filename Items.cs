using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortix
{
    internal class Items
    {
        public static Dictionary<string, int> costs = new Dictionary<string, int>();
        public string Name;
        public int Price;
        public static int[] prices = new int[] {0, 0, 0, 0, 0, 0};
        public static string[] names = new string[] {"", "", "", "", "", "" };
        public Items(string name, int price) // конструкторы краш
        {
            Name = name;
            Price = price;
        }
    }
}
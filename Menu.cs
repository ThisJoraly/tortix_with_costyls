using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortix
{
    internal class Menu
    {
        Items one;
        Items two;
        Items three;
        public Items Show(int pos)
        {
            int funcpos = 0;
            Console.Clear();
            int price = 0;
            if (pos == 0)
            {
                int prevpos = pos;
                one = new Items("Круглый", 1000);
                two = new Items("Квадратный", 9000);
                three = new Items("Прямоугольный", 1100);
                switch (pos)
                {
                    case 1:
                        
                        break;
                    case 2:
                        Items.prices[prevpos] = two.Price;
                        break;
                    case 3:
                        Items.prices[prevpos] = three.Price;
                        break;
                }
            }
            else if (pos == 1)
            {
                one = new Items("Маленький", 500);
                two = new Items("Средний", 900);
                three = new Items("Большой", 1000);
                
            }
            else if (pos == 2)
            {
                one = new Items("Клубничный корж", 700);
                two = new Items("Шоколадный корж", 900);
                three = new Items("Ванильный корж", 1000);
                
            }
            else if (pos == 3)
            {
                one = new Items("Два коржа", 500);
                two = new Items("Три коржа", 900);
                three = new Items("Четыре коржа", 1000);
                
            }
            else if (pos == 4)
            {
                one = new Items("Шоколадная глазурь", 500);
                two = new Items("Ягодная глазурь", 900);
                three = new Items("Глазурь-безе", 1000);
                
               
            }
            else if (pos == 5)
            {
                one = new Items("Шоколадный декор", 500);
                two = new Items("Ягодный декор", 900);
                three = new Items("Декор - микс", 1200);
                
            }

            while (true)
            {
                if (funcpos < 2) { funcpos = 2; }
                if (funcpos > 4) { funcpos = 4; }
                Func(one, two, three);
                Console.SetCursorPosition(0, funcpos);
                Console.WriteLine("->");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape) { break; }

                if (key.Key == ConsoleKey.UpArrow)
                {
                    funcpos--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    funcpos++;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    if (funcpos == 2)
                    {
                        Items.prices[pos] = one.Price;
                        Items.names[pos] = one.Name;
                        return one;
                    }
                    else if (funcpos == 3)
                    {
                        Items.prices[pos] = two.Price;
                        Items.names[pos] = two.Name;
                        return two;
                    }
                    else if (funcpos == 4)
                    {
                        Items.prices[pos] = three.Price;
                        Items.names[pos] = three.Name;
                        return three;
                    }
                    break;
                }
                Console.Clear();
            }
            return one = new Items("", 0);
        }
        private void Func(Items one, Items second, Items third)
        {
            Console.WriteLine("Выберите один из параметров: ");
            Console.WriteLine("-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine($"1. {one.Name}");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine($"2. {second.Name}");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine($"3. {third.Name}");
            Console.WriteLine("-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-");
        }

    }
}
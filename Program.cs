namespace Tortix
{
    // как же я уже устал от этих тортиксов у меня глаза уже болят от этой темы в райдере помогите ааааа
    // спасибо папаша что не надо мне будет мучаться с отчетом вот это говнокода, я ненавижу тортики
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Console.Clear();
            //мяу
            bool MainExitTrigger = true;
            List<Items> show = new List<Items>();
            while (MainExitTrigger)
            {
                int pos = 3;
                //foreach (var ins in Items.prices)
                //{
                //    Console.Write(ins + "\t");
                //}
                int summa = Items.prices[0] + Items.prices[1] + Items.prices[2] + Items.prices[3] + Items.prices[4] + Items.prices[5];
                string opisaniye = Items.names[0] + " | " + Items.names[1] + " | " + Items.names[2] + " | " +Items.names[3] + " | " +Items.names[4] + " | " +  Items.names[5];
                bool ExitTrigger = true;
                Menu m = new Menu();
                while (ExitTrigger)
                {
                    
                    if (pos < 3) { pos = 9; }
                    if (pos > 9) { pos = 3; }
                    Console.WriteLine("Добро пожаловать в торт-мейкер");
                    Console.WriteLine("Для заказа выберите пункт, следом нажмите [Завершить покупку]");
                    Console.WriteLine("-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-");
                    Console.SetCursorPosition(2, 3);
                    Console.WriteLine("1. [Форма торта]");
                    Console.SetCursorPosition(2, 4);
                    Console.WriteLine("2. [Размер торта]");
                    Console.SetCursorPosition(2, 5);
                    Console.WriteLine("3. [Вкус торта]");
                    Console.SetCursorPosition(2, 6);
                    Console.WriteLine("4. [Кол-во коржей]");
                    Console.SetCursorPosition(2, 7);
                    Console.WriteLine("5. [Глазурь торта]");
                    Console.SetCursorPosition(2, 8);
                    Console.WriteLine("6. [Декор для торта]");
                    Console.SetCursorPosition(2, 9);
                    Console.WriteLine("7. [Завершить покупку]");
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-");
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("[Цена вашего торта]: " + summa);
                    Console.SetCursorPosition(0, 12);
                    Console.Write("[Итог]: " + opisaniye);
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Escape) { ExitTrigger = false; MainExitTrigger = false; }

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        pos--;
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        pos++;
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (pos == 9)
                        {
                            Console.WriteLine(Items.prices[0] + Items.prices[1]);
                            
                            MainExitTrigger = false;
                            ExitTrigger = false;
                            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            path = path.Replace(@"\", @"\\");
                            path = path + "\\orders.txt";
                        
                            string info = "Заказ от: " + Convert.ToString(DateTime.Now) + '\n' + "\tЗаказ: " + opisaniye + '\n' + "\tЦена: " + summa + '.';
                            if (!File.Exists(path))
                            {
                                File.Create(path).Dispose();
                                File.AppendAllText(path, info);
                            }
                            else { File.AppendAllText(path, '\n' + info); }

                            Console.Clear();
                            Console.WriteLine("Ваш заказ готов!");
                            Console.WriteLine("Не желаете сделать еще один заказ? Y/N");
                            string st = Console.ReadLine();
                            st = st.ToLower();
                            if (st != "y")
                            {
                                ExitTrigger = false;
                                return;
                            }
                            else
                            {
                                Start();
                            }
                            
                            break;
                            
                        }
                        else
                        {
                            Items item;
                            item = m.Show(pos - 3);
                            show.Add(item);
                        }
                        
                        
                        
                        break;
                    }
                    Console.Clear();
                }
                Console.Clear();
            }
        }
    }
}
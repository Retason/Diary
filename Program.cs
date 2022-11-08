namespace Ezhednevnik

{
    internal class Program

    {
        static void Main(string[] args)
            
        {
            List<string> dva = new List<string> { "  1. Помыть посуду", "  2. Убрать комнату" };


            day1();
        }
        
        
        static void day1()

        {
            
            List<string> odin = new List<string> { "  1. Приготовить ужин", "  2. Почистить пк" };
            Console.WriteLine("\tЗаметки 25.05.2022");
            Console.WriteLine(odin[0]);
            Console.WriteLine(odin[1]);
            string F = "Время создания заметки: ";

            int b = 1;
            Console.SetCursorPosition(0, b);
            Console.WriteLine("->");
            ConsoleKeyInfo a = Console.ReadKey();

            while (a.Key != ConsoleKey.Enter)

            {
                if (a.Key == ConsoleKey.UpArrow)

                {
                    b--;
                    Console.Clear();
                    Console.WriteLine("\tЗаметки 26.05.2022");
                    Console.WriteLine(odin[0]);
                    Console.WriteLine(odin[1]);
                }

                else if (a.Key == ConsoleKey.DownArrow)

                {
                    b++;
                    Console.Clear();
                    Console.WriteLine("\tЗаметки 27.05.2022");
                    Console.WriteLine(odin[0]);
                    Console.WriteLine(odin[1]);
                }

                Console.SetCursorPosition(0, b);
                Console.WriteLine("->");
                a = Console.ReadKey();

                if (a.Key == ConsoleKey.RightArrow) { Console.Clear(); day2(); }
                else if (a.Key == ConsoleKey.LeftArrow) { Console.Clear(); day3(); }

            }

            if (b == 1)

            {
                Console.Clear();
                Console.WriteLine(odin[0] + " - Сварить котлетки, пожарить макарошки");
                Console.WriteLine();
                Console.WriteLine(F + "25.05.2022 - 04:30:27");
            }

            else if (b == 2)

            {
                Console.Clear();
                Console.WriteLine(odin[1] + " - Разобрать, подуть, собрать");
                Console.WriteLine();
                Console.WriteLine(F + "23.05.2022 - 15:13:14");
            }
            Console.ReadKey();
            Console.Clear();
            day1();

            static void day2()
            {

                List<string> dva = new List<string> { "  1. Сделать C#", "  2. Пойти в рейтинг" };

                Console.WriteLine("\tЗаметки 07.11.2022");
                Console.WriteLine(dva[0]);
                Console.WriteLine(dva[1]);
                string F = "Время создания заметки: ";

                int b = 1;
                Console.SetCursorPosition(0, b);
                Console.WriteLine("->");
                ConsoleKeyInfo a = Console.ReadKey();

                while (a.Key != ConsoleKey.Enter)

                {
                    if (a.Key == ConsoleKey.UpArrow)

                    {
                        b--;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 06.11.2022 - 03:20:32");
                        Console.WriteLine(dva[0]);
                        Console.WriteLine(dva[1]);
                    }

                    else if (a.Key == ConsoleKey.DownArrow)

                    {
                        b++;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 05.11.2022 - 21:45:39");
                        Console.WriteLine(dva[0]);
                        Console.WriteLine(dva[1]);
                    }

                    Console.SetCursorPosition(0, b);
                    Console.WriteLine("->");
                    a = Console.ReadKey();
                    if (a.Key == ConsoleKey.RightArrow) { Console.Clear(); day3(); }
                    else if (a.Key == ConsoleKey.LeftArrow) { Console.Clear(); day1(); }
                }

                if (b == 1)
                {
                    Console.Clear();
                    Console.WriteLine(dva[0] + " - Делать много-много C#, ведь дедлайн близок...");
                    Console.WriteLine();
                    Console.WriteLine(F + " 02.11.2022 - 14:33:41");
                }
                else if (b == 2)
                {
                    Console.Clear();
                    Console.WriteLine(dva[1] + " - Зайти в дс, пойти в катку, словить лузстрик, вспомнить про C#");
                    Console.WriteLine();
                    Console.WriteLine(F + " 02.11.2022 - 18:32:12");
                }
                Console.ReadKey();
                Console.Clear();
                day2();
            }

            static void day3()
            {
                List<string> tri = new List<string> { "  1. Съездить в тц" };
                Console.WriteLine("\tЗаметки 21.05.2022");
                Console.WriteLine(tri[0]);
                string F = "Время создания заметки: ";

                int b = 1;
                Console.SetCursorPosition(0, b);
                Console.WriteLine("->");
                ConsoleKeyInfo a = Console.ReadKey();

                while (a.Key != ConsoleKey.Enter)
                {
                    if (a.Key == ConsoleKey.UpArrow)
                    {
                        b--;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 21.05.2022");
                        Console.WriteLine(tri[0]);

                    }
                    else if (a.Key == ConsoleKey.DownArrow)
                    {
                        
                        b++;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 21.05.2022");
                        Console.WriteLine(tri[0]);

                    }
                    Console.SetCursorPosition(0, b);
                    Console.WriteLine("->");
                    a = Console.ReadKey();

                    if (a.Key == ConsoleKey.RightArrow) { Console.Clear(); Console.WriteLine("Ваши заметки кончились, переход к первой заметке"); day1(); }
                    else if (a.Key == ConsoleKey.LeftArrow) { Console.Clear(); day2(); }
                }

                Console.Clear();
                Console.WriteLine(tri[0] + "  - Приехать в тц, погулять по тц, пойти в мак");
                Console.WriteLine();
                Console.WriteLine(F + " 10.10.2022 - 21:12:32");

            }

        }

    }

}

using System;
using System.Collections.Generic;

namespace LW_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = new string[] { "1. Среди заданных чисел найти количество четных чисел",
                                            "2. Вывести в порядке возрастания все целые числа, расположенные между А и В",
                                            "3. Найти среднее арифметическое введенных чисел, исключая последнее",
                                            "4. Выйти из программы"};

            int index = 0;
            while (true)
            {
                DrawMenu(items, index);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < items.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (index)
                        {
                            case 0:
                                {
                                    
                                    break;
                                }
                            case 1:
                                {
                                    
                                    break;
                                }
                            case 2:
                                {
                                    double res;
                                    Console.WriteLine("Введите последовательность положительных чисел (конец - ноль или отрицательное число");
                                    res = Seq_num();
                                    Console.WriteLine("Среднее арифметическое: {0:g2}", res);
                                    break;
                                }
                            case 3:
                                return;
                        }
                        Console.WriteLine("\nДля выхода в меню нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        static double Seq_num()
        {
            List<double> arr = new List<double>();
            double x;
            while (true)
            {
                x = GetDouble();
                if (x <= 0)
                    break;
                arr.Add(x);
            }
            x = 0;
            foreach (double num in arr)
                x += num;
            return x / arr.Count;
        }

        private static void DrawMenu(string[] items, int index)
        {
            string variant = "В а р и а н т   № 9";
            int centerX = (Console.WindowWidth / 2) - (variant.Length / 2) - 5;
            Console.SetCursorPosition(centerX, 1);
            Console.WriteLine(variant);
            Console.SetCursorPosition(0, 3);
            for (int i = 0; i < items.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(items[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }


        private static double GetDouble()
        {
            int cur_y = Console.CursorTop;
            int cur_x = Console.CursorLeft;
            double res;
            while (!double.TryParse(Console.ReadLine(), out res))
            {
                Console.SetCursorPosition(cur_x, cur_y);
                Console.WriteLine("Не удалось получить значение, попробуйте ещё раз. Нажмите любую клавишу...");
                Console.ReadKey();
                Console.SetCursorPosition(cur_x, cur_y);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(cur_x, cur_y);
            }
            return res;
        }

        private static char GetChar()
        {
            int cur_y = Console.CursorTop;
            int cur_x = Console.CursorLeft;
            char res;
            while (!char.TryParse(Console.ReadLine(), out res))
            {
                Console.SetCursorPosition(cur_x, cur_y);
                Console.WriteLine("Не удалось получить символ, попробуйте ещё раз. Нажмите любую клавишу...");
                Console.ReadKey();
                Console.SetCursorPosition(cur_x, cur_y);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(cur_x, cur_y);
            }
            return res;
        }

        private static int GetInt()
        {
            int cur_y = Console.CursorTop;
            int cur_x = Console.CursorLeft;
            int res;
            while (!int.TryParse(Console.ReadLine(), out res))
            {
                Console.SetCursorPosition(cur_x, cur_y);
                Console.WriteLine("Не удалось получить число, попробуйте ещё раз. Нажмите любую клавишу...");
                Console.ReadKey();
                Console.SetCursorPosition(cur_x, cur_y);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(cur_x, cur_y);
            }
            return res;
        }
    }
}
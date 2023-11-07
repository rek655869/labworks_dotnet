using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4
{
    public class Exercise4
    {
        public static void Excercise4()
        {
            double res;
            Console.WriteLine("Введите последовательность положительных чисел (конец - ноль или отрицательное число):");
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
            res = x / arr.Count;
            Console.WriteLine("Среднее арифметическое: {0:g2}", res);
            Console.WriteLine("\nДля выхода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }
        private static int GetDigit(int res)
        {
            int cur_y = Console.CursorTop;
            int cur_x = Console.CursorLeft;
            while (!int.TryParse(Console.ReadLine(), out res))
            {
                Console.SetCursorPosition(cur_x, cur_y);
                Console.WriteLine("Не удалось распознать число, попробуйте ещё раз. Нажмите любую клавишу...");
                Console.ReadKey();
                Console.SetCursorPosition(cur_x, cur_y);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(cur_x, cur_y);
            }
            return res;
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
    }
}

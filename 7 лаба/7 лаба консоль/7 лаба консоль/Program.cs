using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_лаба_консоль
{
    internal class Program
    {
        static int Ex_1_3(int n)
            {
            int res = 0;
            int[] mas = new int[n];
            Random random = new Random();
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                mas[i] = random.Next(-10, 10);
                Console.Write(mas[i] + " ");
                if (mas[i] > 0)
                    res++;
            }
            return res;
        }

        static int Ex_2_u(ref int a, ref int b)
        {
            if (a > (b - a))
               return a;
            else return (b-a);
        }
        static int Ex_2_v(ref int a, ref int b)
        { 
            if (a*b < (a + b))
                return a*b; 
            else return (a+b);
        }

        static double Ex_2(in int u, in int v, out double k)
        { 
            if ((u + Math.Pow(v, 2)) < 3.14)
                 k = (u + Math.Pow(v, 2));
            else k = 3.14;
            return k;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.3");
            Console.Write("Введите количество строк двумерного массива\n>");
            int n = GetInt();
            int res = Ex_1_3(n);
            Console.Write("\n\nКоличество положительных элементов массива: {0} ", res);
            Console.ReadKey();
            Console.WriteLine("\n\nЗадание 2");
            Console.Write("Введите a\n>");
            int a = GetInt();
            Console.Write("Введите b\n>");
            int b = GetInt();
            int u = Ex_2_u(ref a,ref b);
            int v = Ex_2_v(ref a,ref b);
            Ex_2(in u,in v, out double result);
            Console.Write(" Значение k = {0}", result);
            Console.ReadKey();
        }
        private static int GetInt()
        {
            int cur_y = Console.CursorTop;
            int cur_x = Console.CursorLeft;
            int res;
            while (!int.TryParse(Console.ReadLine(), out res))
            {
                Console.SetCursorPosition(cur_x, cur_y);
                Console.WriteLine("Не удалось получить значение,введите положительное число. Нажмите любую клавишу...");
                Console.ReadKey();
                Console.SetCursorPosition(cur_x, cur_y);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(cur_x, cur_y);
            }
            return res;
        }
    }

}

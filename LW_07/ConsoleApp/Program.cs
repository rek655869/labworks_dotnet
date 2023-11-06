using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                switch (args[0])
                {
                    case "1":
                        {
                            Exercise_1();
                            break;
                        }
                    case "2":
                        {
                            Exercise_2();
                            break;
                        }
                    case "3":
                        {
                            Exercise_3();
                            break;
                        }
                    case "4":
                        {
                            Exercise_4();
                            break;
                        }
                    case "5":
                        {
                            Exercise_5();
                            break;
                        }
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели символ, а нужно число");
            }
        }

        static void Exercise_1()
        {
            int res_ex1;
            int col, row;
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите количество строк двумерного массива");
            Console.Write("> ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            Console.Write("> ");
            col = Convert.ToInt32(Console.ReadLine());
            res_ex1 = function_mass_excersice1_1(row, col);
            Console.WriteLine("Количество строк, в которых есть минимальный по модулю элемент массива = {0}", res_ex1);

        }

        static void Exercise_2()
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine("a = x^2 / (8 + (x^2 / 3) + y^2 / 6");
            Console.WriteLine("b = x * (cos^3(x + z) + 1)");
            Console.WriteLine("Введите значение x");
            Console.Write("> ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y");
            Console.Write("> ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение z");
            Console.Write("> ");
            double z = Convert.ToDouble(Console.ReadLine());
            double a, b;
            exercise_1_2(out a, out b, x, y, z);
            Console.WriteLine("A = " + Math.Round(a, 3));
            Console.WriteLine("B = " + Math.Round(b, 3));
        }

        static void Exercise_3()
        {

        }

        static void Exercise_4()
        {

        }

        static void Exercise_5()
        {
            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите количество элементов в массиве больше 1");
            Console.Write("> ");
            int col_el = Convert.ToInt32(Console.ReadLine());
            while (col_el < 2)
            {
                Console.WriteLine("Введите количество элементов в массиве больше 1");
                Console.Write("> ");
                col_el = Convert.ToInt32(Console.ReadLine());
            }
            exercise_3(col_el);
        }



        static int function_mass_excersice1_1(int row, int col)
        {
            int[,] massive = new int[row, col];
            Random random = new Random();
            int count = 0;
            int min_el = 1000;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    massive[i, j] = random.Next(-5, 5);
                    Console.Write("{0,4}", massive[i, j]);
                    if (min_el > Math.Abs(massive[i, j]))
                        min_el = Math.Abs(massive[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Минимальный элемент массива = {0}", min_el);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (min_el == Math.Abs(massive[i, j]))
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
        }

        static void exercise_1_2(out double a, out double b, double x, double y, double z)
        {

            a = Math.Pow(x, 2) / (8 + Math.Pow(x, 2) / 3 + Math.Pow(y, 2) / 6);
            b = x * (Math.Pow(Math.Cos(z + x), 3) + 1);
        }

        static void exercise_3(int count)
        {
            int elemnt_swap;
            int[] massive = new int[count];
            Random random = new Random();
            Console.WriteLine("Массив до перемены элементов местами");
            for (int i = 0; i < count; i++)
            {
                massive[i] = random.Next(20);
                Console.Write("{0,4}", massive[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine("Какой элемент поменять с предыдущим? (кроме 1)");
            elemnt_swap = Convert.ToInt32(Console.ReadLine());
            while (elemnt_swap == 1 || elemnt_swap > count)
            {
                Console.WriteLine("КРОМЕ 1 и числа больше количества элементов массива");
                Console.WriteLine("Какой элемент поменять с предыдущим? (кроме 1)");
                elemnt_swap = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < count; i++)
            {
                if (i == elemnt_swap - 1)
                {
                    swap(ref massive[i], ref massive[i - 1]);
                }
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(massive[i] + " ");
            }
        }

        static void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}

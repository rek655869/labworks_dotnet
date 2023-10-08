using System;
using System.Collections.Generic;

namespace LW_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            switch (args[0])
            {
                case "1":
                    {
                        //Среди заданных чисел найти количество четных чисел.
                        Excercise2();
                        break;
                    }
                case "2":
                    {
                        // Целые числа в (A; В) и их количество
                        Excercise3();
                        break;
                    }
                case "3":
                    {
                        // Среднее арифметическое введённых чисел
                        Excercise4(); 
                        break;
                    }
            }
        }

        static void Excercise2()
        {
            Console.WriteLine("         Задание №2");
            bool program = true;
            while (program)
            {
                try
                {
                    int res;
                    Console.Write("Введите размер массива - ");
                    int size = Convert.ToInt32(Console.ReadLine());
                    int[] numbers = new int[size];
                    int k = 0;
                    for (int i = 0; i < size; i++)
                    {

                        Console.Write("{0} - ", i + 1);
                        string answer = Console.ReadLine();
                        if (!int.TryParse(answer, out res))
                        {
                            i--;
                            continue;
                        }
                        if (int.TryParse(answer, out res))
                        {
                            numbers[i] = Convert.ToInt32(answer);
                            if (numbers[i] % 2 == 0)
                                k++;
                        }

                    }
                    Console.WriteLine(k);
                    Console.WriteLine("Хотите ли продолжить? y - да, n - нет");
                    string choice = Console.ReadLine();
                    while (choice != "n" && choice != "y")
                    {
                        Console.WriteLine("Вы ввели что-то не так, попробуйте снова!!!");
                        Console.WriteLine("Хотите ли продолжить? y - да, n - нет");
                        choice = Console.ReadLine();
                    }

                    if (choice == "n")
                    {
                        program = false;
                        break;
                    }



                }
                catch
                {
                    Console.WriteLine("Вы ввели что-то не так, попробуйте снова!!!");
                }
            }
            Console.Clear();
            Console.WriteLine("         Задание №2");
            Console.WriteLine("Программа завершена");

        }

        static void Excercise3()
        {
            int A = 0, B = 0, N = 0, min = 0, max = 0;
            Console.Write("Введите значение A: \n");
            A = GetDigit(A);
            Console.Write("Введите значение B: \n");
            B = GetDigit(B);
            Console.Write("Числа, расположенные между A и B: ");
            if (A < B)
            {
                min = A;
                max = B;
            }
            else
            {
                min = B;
                max = A;
            }
            for (int i = min + 1; i < max; i++)
            {
                Console.Write("{0} ", i);
                N++;

            }
            Console.Write("\nКоличество чисел между A и B = {0}\n", N);
            Console.WriteLine("\nДля выхода в меню нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void Excercise4()
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
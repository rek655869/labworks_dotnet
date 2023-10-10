using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Запуск программы возможен только из формы");
                return;
            }
            switch (args[0])
            {
                case "1":
                    {
                        //Среди заданных чисел найти количество четных чисел.
                        Console.WriteLine("\t\t\tЗадание 1");
                        Console.WriteLine("\t\t\t      2^k");
                        Console.WriteLine("\t\t\t----------------");
                        Console.WriteLine("\t\t\t(\\|(n) + 3) ^ 2");
                        int n1;
                        Console.Write("Введите размер одномерного массива - ");
                        n1 = Int32.Parse(Console.ReadLine());
                        exercise1_one_dimensional_array(n1);
                        int n, m;
                        Console.Write("Введите количество строк двумерного массива - ");
                        n = Int32.Parse(Console.ReadLine());
                        Console.Write("Введите количество столбцов двумерного массива - ");
                        m = Int32.Parse(Console.ReadLine());
                        exercise1_two_dimensional_array(n, m);
                        Console.ReadKey();
                        break;
                    }
                case "2":
                    {
                        int A;
                        Console.Write("Введите размер массива A - ");
                        A = Int32.Parse(Console.ReadLine());
                        int B;
                        Console.Write("Введите размер массива B - ");
                        B = Int32.Parse(Console.ReadLine());
                        while (A <= 0 || B <= 0)
                        {
                            Console.WriteLine("ОШИБКА! Вы ввели что-то не так, попробуйте снова");

                            Console.Write("Введите размер массива A - ");
                            A = Int32.Parse(Console.ReadLine());
                            Console.Write("Введите размер массива B - ");
                            B = Int32.Parse(Console.ReadLine());


                        }
                        exercise2(A, B);
                        Console.ReadKey();
                        break;
                    }
                case "3":
                    {
                        uint n;
                        double t, sum = 0, k = 0;
                        Console.Write("Введите размер массива n*n: ");
                        n = GetInt();
                        Console.Write("\nВведите число для сравнения с элементами массива: ");
                        t = GetDouble();
                        Console.WriteLine("\nМассив:");
                        List<List<double>> A = new List<List<double>>();
                        List<double> row = new List<double>();
                        Random rand = new Random();
                        for (int i = 0; i < n; i++)
                        {
                            row = new List<double>();
                            for (int j = 0; j < n; j++) row.Add(i + j);
                            A.Add(row);
                        }

                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                A[i][j] = rand.NextDouble() + rand.Next(10);
                                A[i][j] = Math.Round(A[i][j], 1);
                                if (A[i][j] > t)
                                {
                                    sum += A[i][j];
                                    k++;
                                }
                                if (A[i][j] == (int)A[i][j])
                                    Console.Write(" " + A[i][j].ToString() + "   ");
                                else Console.Write(A[i][j].ToString() + "  ");

                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("\nЧисло элементов массива a(i,j) > {0}: {1} ", t, k);
                        Console.WriteLine("Сумма элементов массива (a(i,j) > {0}): {1}\n ", t, Math.Round(sum, 2));
                        Console.ReadKey();
                        break;
                    }
                case "4":
                    {
                        uint m;
                        Console.Write("Введите размер массива: ");
                        m = GetInt();
                        double[] arr = new double[m];
                        Random random = new Random();
                        Console.WriteLine("\nИсходный массив: ");
                        for (int i = 0; i < m; i++)
                        {
                            arr[i] = random.NextDouble() + random.Next(10);
                            arr[i] = Math.Round(arr[i], 1);
                            Console.Write(arr[i] + " ");

                        }
                        Sort(arr, m);

                        Console.WriteLine("\nМассив после сортировки: ");
                        for (int i = 0; i < m; i++)
                            Console.Write(arr[i] + " ");
                        Console.ReadKey();
                        break;
                    }
            }
        }

        static void exercise1_one_dimensional_array(int n) //одномерный массив
        {
            Random random = new Random();
            int k;

            double[] arr = new double[n];
            Console.WriteLine("\t\tОдномерный массив размером - {0}", n);
            for (int i = 0; i < n; i++)
            {
                k = random.Next(10);

                if (i == n - 1)
                {
                    Console.WriteLine(arr[i]);
                }
                else
                {
                    arr[i] = Math.Round((Math.Pow(2, k)) / (Math.Pow((Math.Sqrt(n) + 3), 2)), 2);
                    Console.Write(arr[i] + "\t");
                }
            }
        }
        static void exercise1_two_dimensional_array(int n, int m) // двумерный массив
        {

            int k;
            List<List<double>> Mas = new List<List<double>>();    //динамический двумерный массив
                                                                  //строка массива
            double zamena;
            Random random = new Random();


            Console.WriteLine("\t\tДвумерный массив размером - {0}*{1}", n, m);

            for (int i = 0; i < n; i++)
            {
                List<double> row = new List<double>(); //создается новая строка, в которую мы запихиваем значения zamena
                for (int j = 0; j < m; j++)
                {

                    k = random.Next(20);
                    zamena = Math.Round((Math.Pow(2, k)) / (Math.Pow((Math.Sqrt(n) + 3), 2)), 2);
                    row.Add(zamena);
                    Console.Write(row[j].ToString() + "\t");

                }
                Mas.Add(row); //заполняем наш массив по строчкам
                Console.WriteLine();
            }

        }
        static void exercise2(int A, int B)
        {
            Random random = new Random();
            int[] array_a = new int[A];
            int[] array_b = new int[B];
            int[] array_a_a = new int[A];
            int[] array_a_b = new int[B];
            int[] array_b_a = new int[A];
            int[] array_b_b = new int[B];
            int min_A = 1000;
            int min_B = 1000;
            Console.WriteLine("Массив А");
            for (int i = 0; i < A; i++) //заполняем массив А рандомн числами в пределах 40
            {
                array_a[i] = random.Next(40);
                Console.Write(array_a[i] + "\t");

            }
            Console.WriteLine();
            Console.WriteLine("Массив B");
            for (int i = 0; i < B; i++)//заполняем массив B рандомн числами в пределах 40
            {
                array_b[i] = random.Next(40);
                Console.Write(array_b[i] + "\t");

            }
            Console.WriteLine();
            for (int i = 0; i < A; i++) //находим минимальное в массиве А
            {
                if (array_a[i] < min_A)
                {
                    min_A = array_a[i];
                }

            }
            for (int i = 0; i < B; i++) //находим минимальное в массиве B
            {
                if (array_b[i] < min_B)
                {
                    min_B = array_b[i];
                }

            }
            Console.WriteLine("Массив А * минимальное А");
            for (int i = 0; i < A; i++) //перемножаем минимальное массива А на все элементы массива А
            {
                array_a_a[i] = array_a[i] * min_A;

                Console.Write(array_a_a[i] + "\t");

            }
            Console.WriteLine();
            Console.WriteLine("Массив В * минимальное А");
            for (int i = 0; i < B; i++) //перемножаем минимальное массива А на все элементы массива В
            {
                array_a_b[i] = array_b[i] * min_A;
                Console.Write(array_a_b[i] + "\t");

            }
            Console.WriteLine();
            Console.WriteLine("Массив А * минимальное В");
            for (int i = 0; i < A; i++) //перемножаем минимальное массива В на все элементы массива А
            {
                array_b_a[i] = array_a[i] * min_B;
                Console.Write(array_b_a[i] + "\t");

            }
            Console.WriteLine();
            Console.WriteLine("Массив В * минимальное В");
            for (int i = 0; i < B; i++) //перемножаем минимальное массива В на все элементы массива В
            {
                array_b_b[i] = array_b[i] * min_B;
                Console.Write(array_b_b[i] + "\t");

            }
            Console.WriteLine();
        }

        private static uint GetInt()
        {
            int cur_y = Console.CursorTop;
            int cur_x = Console.CursorLeft;
            uint res;
            while (!uint.TryParse(Console.ReadLine(), out res))
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
        public static void Sort(double[] num, uint size)
        {
            for (int i = 1; i < size; i++)
            {
                double value = num[i];
                int index = i;
                while ((index > 0) && (num[index - 1] > value))
                {
                    num[index] = num[index - 1];
                    index--;
                }
                num[index] = value;

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    public class Exercise2
    {
        public static void Excercise2()
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
    }
}

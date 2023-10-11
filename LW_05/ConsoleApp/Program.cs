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
            }
        }

        static void Exercise_1()
        {
            bool program = true;
            while (program)
            {
                Console.WriteLine("\t\tУДАЛЕНИЕ ПРОБЕЛОВ ИЗ СТРОКИ");
                try
                {
                    string s1, s2;
                    Console.WriteLine("Введите строку с пробелами!");
                    s1 = Console.ReadLine();
                    while (String.IsNullOrWhiteSpace(s1))
                    {
                        Console.WriteLine("Вы ничего не ввели, попробуйте снова!!!");
                        Console.WriteLine("Введите строку!");
                        s1 = Console.ReadLine();
                    }
                    Console.Write("Вы ввели строку - ");
                    Console.WriteLine(s1);
                    int count = 0;
                    for (int i = 0; i < s1.Length; i++)
                    {
                        if (s1[i] == ' ')
                            count += 1;
                    }
                    while (count == 0)
                    {
                        Console.WriteLine("Вы ввели строку без пробелов, попробуйте снова!!!");
                        Console.WriteLine("Введите строку!");
                        s1 = Console.ReadLine();
                        for (int i = 0; i < s1.Length; i++)
                        {
                            if (s1[i] == ' ')
                                count += 1;
                        }
                    }

                    s2 = s1.Replace(" ", "");
                    Console.Write("После того, как были убраны все пробелы - ");
                    Console.WriteLine(s2);
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
            Console.WriteLine("\t\tУДАЛЕНИЕ ПРОБЕЛОВ ИЗ СТРОКИ");
        }

        static void Exercise_2()
        {
            string[] words;
            string text;
            while (true)
            {
                Console.Write("Введите последовательность слов: ");
                text = Console.ReadLine();
                words = text.Remove(text.Length - 1).Split(' ');
                if (words.Length < 2 || words.Length > 30)
                {
                    Console.WriteLine("Количество слов должно быть от 2 до 30. Нажмите любую клавишу, чтобы ввести заново...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                foreach (string word in words)
                {
                    if (word.Length < 2 || word.Length > 30)
                    {
                        Console.WriteLine("В каждом слове должно быть от 2 до 30 букв. Нажмите любую клавишу, чтобы ввести заново...");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                }
                break;
            }

            string last = words[words.Length - 1];
            string new_text = "";

            foreach (string word in words)
            {
                if (word != last)
                {
                    char first = word[0];
                    string new_word = first + word.Replace(first.ToString(), "");
                    new_text += new_word + " ";
                }
            }
            Console.WriteLine(new_text);
            Console.ReadKey();
        }

        static void Exercise_3()
        {
            Console.Write("Введите слово: ");
            string str = Console.ReadLine();
            Console.Write("Результат: {0} ", str.ToUpper());
            Console.ReadKey();
        }
    }
}

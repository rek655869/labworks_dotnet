using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LW_05_ex2_console
{
    internal class Program
    {
        static void Main(string[] args)
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
    }
}

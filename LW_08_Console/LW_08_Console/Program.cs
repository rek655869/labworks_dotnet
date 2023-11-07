using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Security.Policy;

namespace LW_08_Console
{
    internal class Program
    {
        static double exercise1(int numbers)
        {
            FileStream file = new FileStream("C:\\Users\\STALKER\\source\\repos\\LW_08_Console\\file.txt", FileMode.OpenOrCreate); //создаем файл
            StreamWriter writer = new StreamWriter(file); //создаем потоковый писатель
            Random random = new Random();
            
            double[] massive = new double[numbers]; //массив дробных чисел

            for (int i = 0; i < numbers; i++)
            {
                if (i > numbers)
                    break;
                if (i == numbers - 1)
                {
                    massive[i] = Math.Round(random.NextDouble() + random.Next(-10, 10), 2);
                    writer.Write(massive[i] + " ");
                }
                else
                {
                    massive[i] = Math.Round(random.NextDouble() + random.Next(-10, 10), 2);
                    massive[i + 1] = random.Next(-10, 10);
                    writer.Write(massive[i] + " ");
                    writer.Write(massive[i + 1] + " ");
                    i++;
                }  
            }
            writer.WriteLine();
            writer.Close();
            Console.WriteLine();
            FileStream file1 = new FileStream("C:\\Users\\STALKER\\source\\repos\\LW_08_Console\\file.txt", FileMode.Open); //открываем файл
            StreamReader reader = new StreamReader(file1);
            BinaryReader reader2 = new BinaryReader(file1);
            string number = reader.ReadLine();
            double[] massive_read = new double[numbers];
            double sum = 0;
            foreach (var numberr in number.Split()) //в переменную numberr записываем числа, которые отделены друг от друга пробелом
            {
                if (numberr == "") //если числа заканчиваются,то цикл прекращается
                    break;
                
                if (Double.Parse(numberr) % 2 != 0) //проверяем четность
                {
                    sum += Double.Parse(numberr); //находим сумму
                }
                Console.Write(numberr + " ");
                        
            }
            Console.WriteLine();
            
            reader.Close();
            Console.WriteLine();
            return sum;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int numbers;
                    Console.WriteLine("Сколько в файле будет чисел?");
                    Console.Write("> ");
                    numbers = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Сумма четных чисел = " + exercise1(numbers));
                    Console.ReadKey();
                    break;
                }
                catch
                {
                    Console.WriteLine("Вы ввели символ или не ввели ничего, введите число");
                }
            }
            
            
        }
    }
}

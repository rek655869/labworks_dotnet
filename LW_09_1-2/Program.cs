using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace _9_laba_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex_1();
            Ex_2(); 
        }
        public static void Ex_1()
        {
            double x, sum = 0, k;
            var rand = new Random();

            try
            {

                using (FileStream File = new FileStream("file.bin", FileMode.OpenOrCreate))
                {
                    using (BinaryWriter writer = new BinaryWriter(File, Encoding.Default))
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            x = rand.Next(-100, 100) + rand.NextDouble();
                            writer.Write(x);
                            x = rand.Next(-100, 100);
                            writer.Write(x);
                        }
                    }
                }


                using (FileStream File = new FileStream("file.bin", FileMode.Open))
                {
                    using (BinaryReader reader = new BinaryReader(File, Encoding.Default))
                    {
                        Console.Write("Последовательность чисел: ");

                        for (int i = 0; i < 10; i++)
                        {
                            k = reader.ReadDouble();
                            if (Math.Round(k) % 2 == -1 || Math.Round(k) % 2 == 1)
                                sum += k;
                            if (k == (int)k)
                                Console.Write("{0}  ", k);
                            else
                                Console.Write("{0:0.00}  ", k);
                        }

                        Console.WriteLine("\nСумма нечётных чисел в файле - {0:0.00}", sum);
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        public static void Ex_2()
        {
            Console.Write("Введите число, которое хотите вставить в файл:\n > ");
            var rand = new Random();
            double k, y = 0;
            y = num(y);
            int offset = rand.Next(0, 10);
            using (FileStream File = new FileStream("file.bin", FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(File, Encoding.Default))
                {
                    //File.Seek(offset, SeekOrigin.Begin);
                    //File.WriteByte(y);

                    Console.Write("Последовательность чисел с новым числом: ");

                    for (int i = 0; i < 10; i++)
                    {
                        if (i == offset)
                            Console.Write("{0}  ", y);
                        k = reader.ReadDouble();
                        if (k == (int)k)
                            Console.Write("{0}  ", k);
                        else
                            Console.Write("{0:0.00}  ", k);
                    }
                }
                Console.ReadKey();
            }
        }
        public static double num(double s)
        {

            while (true)
            {
                string text = Console.ReadLine();
                if (double.TryParse(text, out double number))
                {

                    Console.WriteLine("Вы ввели число {0}\n", number);
                    s = double.Parse(text);
                    break;
                }
                Console.WriteLine("Некорректное значение! Введите число.\n");
            }
            return s;

        }
    }
}

    

    


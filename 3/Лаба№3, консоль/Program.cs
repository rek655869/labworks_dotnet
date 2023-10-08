﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApplication1
{
    class Programm
    {

        static void Main(string[] args)
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
            for (int i = min+1 ; i < max; i++)
            {
                Console.Write("{0} ", i);
                N++;
                
            }
            Console.Write("\nКоличество чисел между A и B = {0}\n", N);
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
    }
    
}


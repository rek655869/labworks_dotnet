using System;
using System.Collections.Generic;
using Ex_2;
using Ex_3;
using Ex_4;

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
                        Exercise2.Excercise2();
                        break;
                    }
                case "2":
                    {
                        // Целые числа в (A; В) и их количество
                        Exercise3.Excercise3();
                        break;
                    }
                case "3":
                    {
                        // Среднее арифметическое введённых чисел
                        Exercise4.Excercise4();
                        break;
                    }
            }
        }
    }
}
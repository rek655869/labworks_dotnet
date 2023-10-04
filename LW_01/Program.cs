using System;

namespace LW_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            string[] items = new string[] { "1. Вычислить формулы",
                                            "2. По длинам двух сторон треугольника и углу между ними найти длину третьей стороны и площадь треугольника",
                                            "3. Дана точка М(х, у). Проверить, принадлежит ли точка окружности единичного радиуса",
                                            "4. Вычислить длину окружности, площадь круга или объём цилиндра",
                                            "5. Работа со структурой \"Жилой дом\"", 
                                            "6. Выйти из программы"};

            int index = 0;
            while (true)
            {
                DrawMenu(items, index);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < items.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (index)
                        {
                            case 0:
                                {
                                    double x, y, z;
                                    DrawFormulas();
                                    Console.Write("Задайте значение x: ");
                                    x = GetDouble();
                                    Console.Write("Задайте значение y: ");
                                    y = GetDouble();
                                    Console.Write("Задайте значение z: ");
                                    z = GetDouble();
                                    Console.WriteLine("Значение a: {0:g6}", calc.func_a(x, y));
                                    Console.WriteLine("Значение b: {0:g6}", calc.func_b(x, z));
                                    break;
                                }
                            case 1:
                                {
                                    double first, second, angle;
                                    Console.Write("Задайте значение первой стороны: ");
                                    first = GetDouble();
                                    Console.Write("Задайте значение второй стороны: ");
                                    second = GetDouble();
                                    Console.Write("Задайте значение угла в градусах: ");
                                    angle = GetDouble();
                                    if (angle < 0 || angle > 360)
                                    {
                                        Console.WriteLine("Угол не может быть меньше 0 или больше 360");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Значение третьей стороны: {0:g6}", calc.get_third(first, second, angle));
                                        Console.WriteLine("Площадь треугольника: {0:g6}", calc.get_area(first, second, angle));
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    double x, y, z;
                                    Console.Write("Задайте координату X: ");
                                    x = GetDouble();
                                    Console.Write("Задайте координату Y: ");
                                    y = GetDouble();
                                    z = calc.check_point(x, y);
                                    if (z <= 1)
                                        Console.WriteLine("Точка принадлежит единичной окружности, т.к. гипотенуза {0:g6}", z);
                                    else
                                        Console.WriteLine("Точка НЕ принадлежит единичной окружности, т.к. гипотенуза {0:g6}", z);
                                    break;
                                }
                            case 3:
                                {
                                    char sym;
                                    Console.Write("Введите символ (\"L\" - длина окружности, \"S\" - площадь круга, \"V\" - объём цилиндра): ");
                                    sym = GetChar();
                                    if (sym != 'L' && sym != 'S' && sym != 'V')
                                        Console.WriteLine("Нет такого варианта, попробуйте ещё раз");
                                    else
                                    {
                                        switch (sym)
                                        {
                                            case 'L':
                                                {
                                                    double r;
                                                    Console.Write("Задайте радиус: ");
                                                    r = GetDouble();
                                                    Console.WriteLine("Длина окружности составляет {0:g6}", calc.len_circle(r));
                                                    break;
                                                }
                                            case 'S':
                                                {
                                                    double r;
                                                    Console.Write("Задайте радиус: ");
                                                    r = GetDouble();
                                                    Console.WriteLine("Площадь круга составляет {0:g6}", calc.area_circle(r));
                                                    break;
                                                }
                                            case 'V':
                                                {
                                                    double r, h;
                                                    Console.Write("Задайте радиус: ");
                                                    r = GetDouble();
                                                    Console.Write("Задайте высоту: ");
                                                    h = GetDouble();
                                                    Console.WriteLine("Объём цилиндра составляет {0:g6}", calc.vol_cylinder(r, h));
                                                    break;
                                                }
                                        }
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    House h = new House();
                                    int choice;
                                    Console.Write("Введите улицу, на которой расположен дом: ");
                                    h.street = Console.ReadLine();
                                    Console.Write("Введите номер дома: ");
                                    h.number = GetInt();
                                    Console.Write("Введите количество комнат: ");
                                    h.count_rooms = GetInt();
                                    Console.Write("Введите количество этажей: ");
                                    h.count_floors = GetInt();
                                    Console.Write("Есть ли двор (1 - да, 0 - нет): ");
                                    choice = GetInt();
                                    if (choice != 1 && choice != 0)
                                    {
                                        Console.Write("Нет такого варианта");
                                        break;
                                    }
                                    h.yard = Convert.ToBoolean(choice);
                                    h.info();
                                    break;
                                }
                            case 5:
                                return;
                        }
                        Console.WriteLine("\nДля выхода в меню нажмите любую клавишу...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        private static void DrawMenu(string[] items, int index)
        {
            string variant = "В а р и а н т   № 9";
            int centerX = (Console.WindowWidth / 2) - (variant.Length / 2) - 5;
            Console.SetCursorPosition(centerX, 1);
            Console.WriteLine(variant);
            Console.SetCursorPosition(0, 3);
            for (int i = 0; i < items.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(items[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }

        private static void DrawFormulas()
        {
            int centerX = (Console.WindowWidth / 2) - ("a = --------------         b = x * (cos^3(x + z) + 1)".Length / 2) - 5;
            int startY = Console.CursorTop;
            Console.SetCursorPosition(centerX, startY++);
            Console.WriteLine("          x^2");
            Console.SetCursorPosition(centerX, startY++);
            Console.WriteLine("a = --------------         b = x * (cos^3(x + z) + 1)");
            Console.SetCursorPosition(centerX, startY++);
            Console.WriteLine("        x^2   y^2");
            Console.SetCursorPosition(centerX, startY++);
            Console.WriteLine("    8 + --- + ---");
            Console.SetCursorPosition(centerX, startY++);
            Console.WriteLine("         3     6");
            startY++;
            Console.SetCursorPosition(0, startY++);  
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

        private static char GetChar()
        {
            int cur_y = Console.CursorTop;
            int cur_x = Console.CursorLeft;
            char res;
            while (!char.TryParse(Console.ReadLine(), out res))
            {
                Console.SetCursorPosition(cur_x, cur_y);
                Console.WriteLine("Не удалось получить символ, попробуйте ещё раз. Нажмите любую клавишу...");
                Console.ReadKey();
                Console.SetCursorPosition(cur_x, cur_y);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(cur_x, cur_y);
            }
            return res;
        }

        private static int GetInt()
        {
            int cur_y = Console.CursorTop;
            int cur_x = Console.CursorLeft;
            int res;
            while (!int.TryParse(Console.ReadLine(), out res))
            {
                Console.SetCursorPosition(cur_x, cur_y);
                Console.WriteLine("Не удалось получить число, попробуйте ещё раз. Нажмите любую клавишу...");
                Console.ReadKey();
                Console.SetCursorPosition(cur_x, cur_y);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(cur_x, cur_y);
            }
            return res;
        }
    }
    struct House
    {
        public string street;
        public int number;
        public int count_floors;
        public int count_rooms;
        public bool yard;
        
        public void info()
        {
            Console.Write("Дом расположен на улице {0}, {1}.", street, number);
            if (yard)
                Console.Write(" Двор имеется. ");
            else
                Console.Write(" Двора нету. ");
            Console.Write("Количество этажей: {0}, количество комнат: {1}\n", count_floors, count_rooms);
        }
    }
    public class Calculator
    {
        public double func_a(double x, double y) => Math.Pow(x, 2) / (8 + Math.Pow(x, 2) / 3 + Math.Pow(y, 2) / 6);
        public double func_b(double x, double z) => x * (Math.Pow(Math.Cos(z + x), 3) + 1);
        public double get_third(double a, double b, double ang) => Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(ang * Math.PI / 180));
        public double get_area(double a, double b, double ang) => 0.5 * a * b * Math.Sin(ang * Math.PI / 180);
        public double check_point(double a, double y) => Math.Sqrt(Math.Pow(a, 2) + Math.Pow(y, 2));
        public double len_circle(double r) => 2 * Math.PI * r;
        public double area_circle(double r) => Math.PI * Math.Pow(r, 2);
        public double vol_cylinder(double r, double h) => Math.PI * Math.Pow(r, 2) * h;
    }
}
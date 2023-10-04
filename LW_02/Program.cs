using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_02
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Calculator
    {
        public static double func_a(double x, double y) => Math.Pow(x, 2) / (8 + Math.Pow(x, 2) / 3 + Math.Pow(y, 2) / 6);
        public static double func_b(double x, double z) => x * (Math.Pow(Math.Cos(z + x), 3) + 1);
        public static double get_third(double a, double b, double ang) => Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(ang * Math.PI / 180));
        public static double get_area(double a, double b, double ang) => 0.5 * a * b * Math.Sin(ang * Math.PI / 180);
        public static double check_point(double a, double y) => Math.Sqrt(Math.Pow(a, 2) + Math.Pow(y, 2));
        public static double len_circle(double r) => 2 * Math.PI * r;
        public static double area_circle(double r) => Math.PI * Math.Pow(r, 2);
        public static double vol_cylinder(double r, double h) => Math.PI * Math.Pow(r, 2) * h;
    }

    struct СargoPlane
    {
        public string name;
        public double middle_cargo;
        public double fuel_consumption;
        public double flight_range;
        public bool autopilot;

        public string info()
        {
            string str = "";
            str = string.Format("Самолёт {0} имеет среднюю грузоподъёмность {1:g6} тонн, расход топлива {2:g6} кг/ч, дальность полёта {3:g6}. ", 
                name, middle_cargo,  fuel_consumption, flight_range);
            if (autopilot)
                str += "Есть автопилот.";
            else
                str += "Нет автопилота.";
            return str;
        }
    }
}

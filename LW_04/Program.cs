using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_04
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

    public struct Helicopter
    {
        public string model;
        public double max_speed;
        public int year;
        public double max_height;
        public int capacity;
    }

    public struct Factory
    {
        public string name;
        public string address;
        public int foundation_year;
        public int employees;
    }

    public struct Teacher
    {
        public string name;
        public string subject;
        public int experience;
    }
}

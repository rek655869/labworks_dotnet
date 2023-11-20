using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_10
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

    class Employee
    {
        public string Surname;
        public string Name;
        public string Middlename;
        public string Post;
        public string Faculty;
        private int Money;
        private int Age;
        public string Login;
        public string Password;
        public int Code;
        public int Key;

        public Employee(string surname, string name, string middlename, string post, string faculty, string login, string password, int code, int key)
        {
            this.Surname = surname;
            this.Name = name;
            this.Middlename = middlename;
            this.Post = post;
            this.Faculty = faculty;
            this.Login = login;
            this.Password = password;
            this.Code = code;
            this.Key = key;
        }

    }
}

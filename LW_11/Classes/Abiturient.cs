using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_11.Classes
{
    public class Abiturient : Person
    {
        public string university;
        public string town;
        private string snils;
        public string University
        {
            get
            { return university; }
            set
            { university = value; }
        }

        public string Town
        {
            get
            { return town; }
            set
            { town = value; }
        }

        public string Snils
        {
            get
            { return snils; }
            set
            { snils = value; }
        }

        public override string Display()
        {
            return base.Display() + "\nПоступает в " + University + " города " + Town + ".\n" + Info();
        }

        public override bool Login(string name, string password, out string message)
        {
            if (name == Username && password == Password)
            {
                message = "Успешная авторизация абитуриента!";
                return true;
            }
            else
            {
                message = "Неправильный пароль!";
                return false;
            }
        }

        public string Info()
        {
            return "Зарегистрирован под номером " + Snils + ".";
        }

        public override void Load(StreamReader reader)
        {
            base.Load(reader);
            University = reader.ReadLine();
            Town = reader.ReadLine();
            Snils = reader.ReadLine();
        }
    }
}

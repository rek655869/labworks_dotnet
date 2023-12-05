using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_11.Classes
{
    public class Person : User
    {
        public string firstname;
        private string lastname;
        private int age;
        private string number;

        public string FirstName
        {
            get
            { return firstname; }
            set
            { firstname = value; }
        }

        public string LastName
        {
            get
            { return lastname; }
            set
            { lastname = value; }
        }
        public int Age
        {
            get
            { return age; }
            set
            { age = value; }
        }

        public string Number
        {
            get
            { return number; }
            set
            { number = value; }
        }

        public override string Display()
        {
            return "Имя - " + FirstName + ";\nФамилия -  " + LastName + ";\nВозраст -  " + Age + ";\nКонтакты - " + Number + ".";
        }

        public override bool Login(string name, string password, out string message)
        {
            if (name == Username && password == Password)
            {
                message = "Успешная авторизация гостя!";
                return true;
            }
            else
            {
                message = "Неправильный пароль!";
                return false;
            }
        }

        public override void Load(StreamReader reader)
        {
            Password = reader.ReadLine();
            FirstName = reader.ReadLine();
            LastName = reader.ReadLine();
            Age = Convert.ToInt32(reader.ReadLine());
            number = reader.ReadLine();
        }
    }
}

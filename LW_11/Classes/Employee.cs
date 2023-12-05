using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_11.Classes
{
    public class Employee : Person
    {
        public string company;
        public string post;
        public string address;
        public string Company
        {
            get
            { return company; }
            set
            { company = value; }
        }
        public string Post
        {
            get
            { return post; }
            set
            { post = value; }
        }

        public string Address
        {
            get
            { return address; }
            set
            { address = value; }
        }

        public override string Display()
        {
            return base.Display() + "\nРаботает в компании '" + Company + "' на должности " + Post + ".\n" + WorkAddress();
        }

        public string WorkAddress()
        {
            return "Адрес компании - " + Address + ".";
        }

        public override bool Login(string name, string password, out string message)
        {
            if (name == Username && password == Password)
            {
                message = "Успешная авторизация сорудника!";
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
            base.Load(reader);
            Company = reader.ReadLine();
            Post = reader.ReadLine();
            Address = reader.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_11.Classes
{
    public abstract class User
    {
        public string name;
        private string password;


        public string Name
        {
            get
            { return name; }
            set
            { name = value; }
        }

        public string Username
        {
            get
            { return name; }
            set
            { name = value; }
        }

        public string Password
        {
            get
            { return password; }
            set
            { password = value; }
        }

        public abstract string Display();

        public abstract bool Login(string name, string password, out string message);

        public abstract void Load(StreamReader reader);
    }
}

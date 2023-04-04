using System;
using System.Collections.Generic;
using System.Text;

namespace LocApp
{
    public class DBusers
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public DBusers(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Project
{
    public class Employee
    {
        private string _name;
        private string _surName;
        public string Name 
        { 
            get => _name;
            set => _name = FormatName(value);
        }
        public string Surname
        {
            get => _surName;
            set => _surName = FormatName(value);
        }
        public string Username { get; set; }
        public byte Age { get; set; }
        public Employee(string name, string surname, string username)
        {
            Name = name;
            Surname = surname;
            Username = username;
        }

        public string FormatName(string name)
        {
            char[] charArray = name.ToCharArray();
            charArray[0] = Char.ToUpper(charArray[0]);
            return new string(charArray);
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App0411.Models
{
    public abstract class Person
    {
        protected static uint id; 
        public uint Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public byte age { get; set; }

        virtual public void Fullname()
        {
            Console.WriteLine($"{name} {surname}");
        } 
    }
}

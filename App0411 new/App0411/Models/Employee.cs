using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App0411.Models
{
    public class Employee : Person
    {
        public double salary { get; set; }
        public string position { get; set; }
        public enum Gender 
        { 
            male = 'm',
            female = 'f',
            other = 'o'
        
        }

        public Employee()
        {
            id++;
            Id = id;
        }


    }
}

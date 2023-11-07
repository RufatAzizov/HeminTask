
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace App0411.Exceptions
{
    public class EmployeeNotFound : Exception
    {
        public EmployeeNotFound(string message) : base(message) { }
    }
}

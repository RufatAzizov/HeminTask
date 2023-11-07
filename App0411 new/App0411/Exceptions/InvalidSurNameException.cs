using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App0411.Exceptions
{
    public class InvalidSurNameException : Exception
    {
        public InvalidSurNameException(string message) : base(message) { }

    }
}

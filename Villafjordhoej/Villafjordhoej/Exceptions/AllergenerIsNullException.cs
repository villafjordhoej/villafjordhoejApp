using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej.Exceptions
{
    class AllergenerIsNullException : Exception
    {
        public AllergenerIsNullException(string message) : base(message)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej.Handler
{
    class NameIsNullException : Exception
    {
        public NameIsNullException(string message) : base(message)
        {
        }
    }
}

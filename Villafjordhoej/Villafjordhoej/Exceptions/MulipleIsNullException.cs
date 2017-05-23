using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villafjordhoej.Exceptions
{
    class MulipleIsNullException : Exception
    {
        public MulipleIsNullException(string message) : base(message)
        {
        }
    }
}

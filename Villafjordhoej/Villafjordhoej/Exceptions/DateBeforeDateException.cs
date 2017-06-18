using System;

namespace Villafjordhoej.Exceptions
{
    public class DateBeforeDateException : Exception
    {
        public DateBeforeDateException(string message) : base(message)
        {
        }
    }
}
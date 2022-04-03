using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_04_2022_Homework.Models.Exceptions
{
    internal class NotAvailableException : Exception
    {
        public NotAvailableException(string message) : base(message)
        { }
    }
}

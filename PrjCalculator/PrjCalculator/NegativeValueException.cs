using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjCalculator
{
    internal class NegativeValueException : Exception
    {
        public NegativeValueException(string Message) 
        {
            Console.WriteLine("Enter only positive numbers");
            
        }
    }
}

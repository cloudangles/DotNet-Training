using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrjCalculator
{
    internal class Calculator
    {

        int result = 0;

        public int Add(int num1, int num2)

        {
           
               try
                {
                if (num1 < 0 || num2 < 0)     throw new NegativeValueException("Enter the positive numbers only");
                    result = num1 + num2;
                    Console.WriteLine("The result of addition is :");
                }
                catch(NegativeValueException e)
                {
                    Console.WriteLine("Enter the positive numbers only!", e.Message);
                }
          
            return result;


        }
        public int sub(int a, int b)
        {
            if (a > b)
            {
                result = a - b;
                Console.WriteLine("The result of substraction is :");
                return result;
            }
            else
            {
                result = b - a;
                Console.WriteLine("The result of substraction is :");
                return result;
            }
        }
        public int mul(int a, int b)
        {
            result = a * b;
            Console.WriteLine("The result of multiplication is :");
            return result;
        }
        public int div(int a, int b)
        {
            try
            {
                result = a / b;
                Console.WriteLine("The result of division is :");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by Zero :", ex.Message);
            }
            return result;
        }
    }
   
}


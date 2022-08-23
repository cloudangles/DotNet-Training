using System;

namespace PrjCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "Hellow How are you?";
            string[] test2 = test.Split(' ');
            
            for (int i = 0; i < test2.Length; i++)
            {
                Console.WriteLine(test2[i]);
            }
            Console.WriteLine("Enter the first number:");
            Console.WriteLine("number is entered");
            int fnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int snum = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            string Operator;
            Calculator calc = new Calculator();
            Console.WriteLine("Enter operator :");
            Operator = Console.ReadLine().ToLower();
            switch (Operator)
            {
                case "add":
                    result = calc.Add(fnum, snum);
                    break;
                case "sub":
                    result = calc.sub(fnum, snum);

                    break;
                case "mul":
                    result = calc.mul(fnum, snum);

                    break;
                case "div":
                    result = calc.div(fnum, snum);

                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.WriteLine(result);
        }
    }
}

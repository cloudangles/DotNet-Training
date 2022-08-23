using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Enter the first number :");
                int fnum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number :");
                int snum = Convert.ToInt32(Console.ReadLine());
                int Ans = 0;

                String Operator;
                Console.WriteLine("Enter the operator (ADD/SUB/MUL/DIV) :");
                Operator = Console.ReadLine().ToUpper();
                switch (Operator)
                {

                    case "ADD":
                        Ans = fnum + snum;
                        Console.WriteLine("The result is:");
                        Console.WriteLine(Ans);
                        break;
                    case "SUB":
                        if (fnum > snum)
                        {
                            Ans = fnum - snum;
                            Console.WriteLine("The result is:");
                            Console.WriteLine(Ans);
                        }
                        else
                        {
                            Ans = snum - fnum;
                            Console.WriteLine("The result is:");
                            Console.WriteLine(Ans);
                        }
                        break;
                    case "MUL":
                        Ans = fnum * snum;
                        Console.WriteLine("The result is:");
                        Console.WriteLine(Ans);
                        break;
                    case "DIV":
                        Ans = fnum / snum;
                        Console.WriteLine("The result is:");
                        Console.WriteLine(Ans);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            Console.WriteLine("Enter any input: Yes/No");
            input = Console.ReadLine();
            }
            
            while (input.Equals ("Yes")) ;

                      

           
        }
    }
}

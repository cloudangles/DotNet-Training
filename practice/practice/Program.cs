using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> lst = new List<string>();
        Console.WriteLine(lst.Capacity);
        lst.Add("s1");
        lst.Add("s2");
        lst.Add("s3");
        lst.Insert(2, "s1.5");
        lst.Remove("s2");
        lst.Remove("s1.5");
        Console.WriteLine("The elements count is :" +lst.Count);
        Console.WriteLine("the capacity is : " +lst.Capacity);
        Console.WriteLine("The string s1 exists : " + lst.Contains("s1"));
        foreach (string s in lst)
        {
            Console.WriteLine("The elememts in string are " +s);
        }
        string[] arString = lst.ToArray();
    }
}

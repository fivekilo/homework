using System;
using System.Text.RegularExpressions;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();
            var rex = new Regex(@"(\d+(\.\d+)?|[\+\-*/])");
            var matches = rex.Matches(s);
            double d1 = double.Parse(matches[0].Value);
            string c = matches[1].Value;
            double d2= double.Parse(matches[2].Value);
            switch (c)
            {
                case "+":
                    Console.WriteLine(d1+d2);
                    break;
                case "-":
                    Console.WriteLine(d1-d2);
                    break;
                case "*":
                    Console.WriteLine(d1*d2);
                    break;
                case "/":
                    if (d2 == 0)
                    {
                        Console.WriteLine("除数不能为0");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(d1 / d2);
                        break;
                    }

            }
        }
    }
}
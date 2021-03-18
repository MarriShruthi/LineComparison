using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison");
            Length line = new Length(5,8,6,10);
            double lengthLine= line.CalculateLength();
            Console.WriteLine("Length of a line =" + lengthLine);
        }
    }
}

using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison");
            Length lineOne = new Length(5,8,6,10);
            double lengthOfLineOne= lineOne.CalculateLength();
            Length lineTwo = new Length(2, 5 , 4, 8);
            double lengthOfLineTwo = lineTwo.CalculateLength();
            Console.WriteLine("Length of two lines are = " + lengthOfLineOne +"  " +lengthOfLineTwo);
            Console.WriteLine(lengthOfLineOne.CompareTo(lengthOfLineTwo));
        }
    }
}

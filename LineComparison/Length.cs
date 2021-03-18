using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class Length
    {
        int startPointOne, startPointTwo, EndPointOne, EndPointTwo;
        public Length(int startPointOne, int startPointTwo, int EndPointOne, int EndPointTwo)
        {
            this.startPointOne = startPointOne;
            this.startPointTwo = startPointTwo;
            this.EndPointOne = EndPointOne;
            this.EndPointTwo = EndPointTwo;
        }
        public double CalculateLength()
        {
            double length = Math.Sqrt((startPointTwo - startPointOne) * (startPointTwo - startPointOne) + (EndPointTwo - EndPointOne) * (EndPointTwo - EndPointOne) );
            return length;
        }
    }
}


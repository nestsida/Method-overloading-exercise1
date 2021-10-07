using System;

namespace Method_overloading_exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int Add( int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return  x + y;

        }
        public static string Add(int x, int y, bool isNow)
        {
            int total = x + y;


            if (isNow == true && total == 1)
            {
                return $"{total} dollar ";
            }
            else if (isNow == true && total > 1)
            {
                return $"{total} dollars ";
            }
            else if (isNow != true);
            {
                return total.ToString();
            }
        }
    }
}

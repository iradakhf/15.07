using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class ExtentionMethods
    {
        public static int Number { get; set; }


        public static bool IsOdd(this int Number)
        {
            bool n = true;
            if (Number % 2 != 0 && Number != 0)
            {
                n = true;
            }
            else
            {
                n = false;
            }
            return n;
        }
        public static bool IsEven(this int Number)
        {
            bool m = true;

            if (Number % 2 == 0 && Number!=0)
            {
                m = true;
            }
            else
            {
                m = false;
            }
            return m;
        }

    }
}

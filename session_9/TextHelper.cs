using System;
using System.Collections.Generic;
using System.Text;

namespace Session09_Assignment
{
    public static class TextHelper
    {
        public static bool IsShorterThan(this string value, int length)
        {
            if (value.Length < length)
                return true;

            return false;
        }

        public static string Repeat(this string value, int times)
        {
            string result = "";
            for(int i = 1;i<=times;i++)
                result+= value ;
            return result;
        }
    }
}

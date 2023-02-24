using System;

namespace Reversed_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static string Solution(string str)
        {
            char[] cArr = str.ToCharArray();
            string temp = "";

            for (int i = cArr.Length - 1; i > -1; i--)
            {
                temp += cArr[i];
            }
            return temp;
        }
    }
}

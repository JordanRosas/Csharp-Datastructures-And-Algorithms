using System;
//Simple coding algorithms reverse a string using recursion
namespace ReverseString
{
    public static class Program
    {
        public static string ReverseStr(string str)
        {
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--)
                result += str[i];
            return result;
        }
    }
}

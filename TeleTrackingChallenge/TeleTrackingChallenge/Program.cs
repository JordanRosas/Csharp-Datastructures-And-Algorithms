using System;

namespace TeleTrackingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IndexOf(args[0], args[1]));
        }
        static int IndexOf(string parentString, string childString)
        {
            //using the IndexOf() method
            //return parentString.IndexOf(childString);

            int childPos = 0;
            for(int i = 0; i < parentString.Length; i++)
            {
                if(childString[childPos] == parentString[i])
                {
                    return i++;
                }
            }
            return - 1;
        }
    }
}

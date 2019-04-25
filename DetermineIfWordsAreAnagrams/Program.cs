using System;

namespace DetermineIfWordsAreAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user input they will enter two words and will be read by the console
            Console.WriteLine("Enter the first word");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Enter the second word");
            string secondWord = Console.ReadLine();
            //need to create two character arrays
            char[] wordOne = firstWord.ToLower().ToCharArray();
            char[] wordTwo = secondWord.ToLower().ToCharArray();
            //sort the arrays in the same order -- Could have done descending order but both need to be sorted the same way!
            Array.Sort(wordOne);
            Array.Sort(wordTwo);
            //Store the new sorted arrays in these variables
            string newWordOne = new string(wordOne);
            string newWordTwo = new string(wordTwo);
            //compare the sorted char[] to see if they are anagrams
            if(newWordOne == newWordTwo)
            {
                Console.WriteLine($"Nice! {newWordOne} and {newWordTwo} are anagrams.");
            }
            else
            {
                Console.WriteLine($"Sorry, {newWordOne} and {newWordTwo} are not anagrams.");
            }

            Console.ReadLine();
        }
    }
}

using System;

namespace RemoveDuplicateLetterInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = RemoveDuplicate("Google");
            string value2 = RemoveDuplicate("Noodle");
            string value3 = RemoveDuplicate("Yahoo");
            string value4 = RemoveDuplicate("Glasses");

            Console.WriteLine("Original Words");
            Console.WriteLine("===================================================");

            string Original = "Google";
            string Original2 = "Noodle";
            string Original3 = "Yahoo";
            string Original4 = "Glasses";

            Console.WriteLine(Original);
            Console.WriteLine(Original2);
            Console.WriteLine(Original3);
            Console.WriteLine(Original4);

            Console.WriteLine("Here are the words without their duplicate letters");
            Console.WriteLine("===================================================");
            //Print each value to the console without the duplicate letters
            Console.WriteLine(value);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(value4);

            Console.WriteLine("Press enter to exit...");
            Console.ReadKey();

        }
        static string RemoveDuplicate(string word)
        {
            //Removes duplicate chars using string concat going to store the encountered doubles in this string
            string doubles = "";

            //Place the result in the string below (The word minus the duplicate letters)
            //ex: Gogle, Nodle, Yaho, Glases
            string result = "";

            //iterate over the characters
            foreach(char letter in word)
            {
                if(doubles.IndexOf(letter) == -1)
                { 
                    doubles += letter;
                    result += letter;
                }
            }
            return result;
        }
    }
}

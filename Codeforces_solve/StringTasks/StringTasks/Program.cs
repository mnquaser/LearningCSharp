using System;
using System.Text;

namespace StringTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine().ToLower());
            var vowels = "aeiouy".ToCharArray();
            var consonent = "bcdfghjklmnpqrstuvwxz".ToCharArray();

            replaceingChars(input, vowels, "");

            replaceingChars(input, consonent, ".{0}");

            Console.WriteLine(input);
        }

      
        /// <summary>
        /// This method takes a StringBuilder, a charArray and a string. 
        /// Then it finds every charecters from charArray in StringBuilder and replaces those charecters with the given string.
        /// </summary>
        /// <param name="inputString"> The targeted StringBuilder to modify </param>
        /// <param name="charArray"> The charArray to make change in inputString </param>
        /// <param name="changedString"> The new string which will be in place of every instances of found chars from charArray, in inputString </param>
        /// <returns></returns>

        private static System.Text.StringBuilder replaceingChars(System.Text.StringBuilder inputString, char[] charArray, string changedString)
        {
            foreach (char charecter in charArray)
            {
                string workingString = charecter.ToString();
                if (inputString.ToString().Contains(workingString))
                {
                    inputString.Replace(workingString, string.Format(changedString, workingString));
                }
            }
            return inputString;
        }

       
    }
}

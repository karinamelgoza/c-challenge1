using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString;

            Console.Write("Please enter your name and press enter: ");
            myString = Console.ReadLine();

            string myStringLowerCase = string.Format($"Lower case: {myString.ToLower()}");
            string myStringUpperCase = string.Format($"Upper case: {myString.ToUpper()}");
            string myStringTrimmed = string.Format($"Trimmed value: {myString.Trim()}");
            string myStringSubstring = string.Format($"Substring value: {myString.Substring(2)}");

            Console.WriteLine(myStringLowerCase);
            Console.WriteLine(myStringUpperCase);
            Console.WriteLine(myStringTrimmed);
            Console.WriteLine(myStringSubstring);
        }
    }
}

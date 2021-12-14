using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyString;

            Console.Write("Please enter your name and press enter");
            MyString = Console.ReadLine();

            Console.WriteLine(MyString.ToUpper());
            Console.WriteLine(MyString.ToLower());
            Console.WriteLine(MyString.Trim());
            Console.WriteLine(MyString.Substring(2));
        }
    }
}

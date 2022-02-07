using System;

namespace DebuggingApplication
{
    class Program
    {
        static void Main(string[] args)
        {    
            string userResponse = Console.ReadLine();
            //condition for user input is integer or not
            if (int.TryParse(userResponse,out int value))//tryparse used for converting string to int and returns conversion successed or not
            {
                Console.WriteLine("The entered value is a integer");
            }
            else
            {
                Console.WriteLine("The entered value is a String");
            }
        }
    }
}

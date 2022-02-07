using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Enter first number:-");
            num1 = int.Parse(Console.ReadLine());//user input number 1
            Console.WriteLine("Enter second number:-");
            num2 = int.Parse(Console.ReadLine());//user input number 2
            int add = num1 + num2; //addition
            Console.WriteLine($"The sum of the {num1} and {num2} is {add}");
            int sub = num1 - num2;//substracion
            Console.WriteLine($"The Substraction of the {num1} and {num2} is {sub}");
            int mul = num1 * num2;//multiplication
            Console.WriteLine($"The Multiplication of the {num1} and {num2} is {mul}");
            int div = num1 / num2;//division
            Console.WriteLine($"The Division of the {num1} and {num2} is {div}");
        }
    }
}

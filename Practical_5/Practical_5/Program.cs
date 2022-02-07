using System;

namespace Practical_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring array 
            int[] arr = new int[5] { 10, 30, 25, 45, 65 };

            //looping over array and printing every element
            try
            {
                foreach(int i in arr)
                {
                    Console.WriteLine(i);  
                }
                Console.WriteLine(arr[5]);//throws exception index out of bound 
            }
            //catch block to print exception message
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //finally block
            finally
            {
                Console.WriteLine("This is finally block");
            }
        }
    }
 }


using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_7
{
    /*its an example of Single Responsibility Principle which says that a class should have only
     one responsibility hence here both the classes are having single responsiblity like employee 
     salary calculates salary and Print salary prints salary */
    public class EmployeeSaLary
    {
        public double perDayRate { get; set; }
        public int numberOfDays { get; set; }
        /// <summary>
        /// calculates salary 
        /// </summary>
        /// <returns>calculated salary in form of double datatype</returns>
        public double CalculateSalary()
        {
            return this.perDayRate * this.numberOfDays;
        }
    }
   
    public class PrintSalary
    {
        /// <summary>
        /// Prints the calculated salary in console
        /// </summary>
        public void PrintSalaray(double salary)
        {
            Console.WriteLine($"Printing Calculated salary: {salary}");
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_7
{
    /*its an example of Open Closed Principle which says that source codes should be open for extension but should be closed for modification
      Here in this code Salaries of Senior and Junior Developers are different hence abstract method is overridden to get OCP Approach*/
    
    //abstract class for method declaration of basesalary calculator
    public abstract class BaseSalaryCalculator
    {
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }
        public abstract void CalculateSalary();
  
    }

   
    public class SeniorDeveloperSalary : BaseSalaryCalculator
    {
        /// <summary>
        /// Calculates senior developer salary
        /// </summary>
     
        public override void  CalculateSalary()
        {
            double sal = WorkingHours * HourlyRate * 1.2;
            Console.WriteLine($"Senior Developer Salary is  {sal}");
        }
    }
    public class juniorDeveloperSalary : BaseSalaryCalculator
    {
        /// <summary>
        /// Calculates junior developer salary
        /// </summary>
        public override void CalculateSalary()
        {
            double sal = WorkingHours * HourlyRate;
            Console.WriteLine($"junior Developer Salary is  {sal}");
        }
    }
   
}

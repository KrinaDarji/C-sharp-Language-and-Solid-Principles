using System;
using System.Collections.Generic;
namespace Practical_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Single Responsibility Principle
            Console.WriteLine("Single Responsibility Principle :- ");
            EmployeeSaLary emp = new EmployeeSaLary { numberOfDays = 20 , perDayRate = 1000};
            double salary = emp.CalculateSalary();
            PrintSalary p = new PrintSalary();
            p.PrintSalaray(salary);
            Console.WriteLine();
            #endregion Single Responsibility Principle
           
            #region Open Closed Principle
            Console.WriteLine("Open Closed Principle : - ");
            SeniorDeveloperSalary s = new SeniorDeveloperSalary();
            s.HourlyRate = 450;
            s.WorkingHours = 8;
            s.CalculateSalary();
            juniorDeveloperSalary j = new juniorDeveloperSalary();
            j.HourlyRate = 450;
            j.WorkingHours = 8;
            j.CalculateSalary();
            Console.WriteLine();
            #endregion Open Closed Principle

            #region Liskov Substitution Principle
            Console.WriteLine("Liskov Substitution Principle : - ");
            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1, "Krina"));
            employees.Add(new TemporaryEmployee(2, "Dhwani"));
            
            List<IEmployee> employeesOnly = new List<IEmployee>();

            employeesOnly.Add(new PermanentEmployee(1, "Krina"));
            employeesOnly.Add(new TemporaryEmployee(2, "Dhwani"));
            employeesOnly.Add(new ContractEmployee(3, "Shivangi"));

            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("Employee {0} Bonus: {1} MinSalary: {2}",
                employee.ToString(),
                employee.CalculateBonus(100000).ToString(),
                employee.GetMinimumSalary().ToString()));
            }
            foreach (var employee in employeesOnly)
            {
                Console.WriteLine(string.Format("Employee {0}  MinSalary: {1}",
                employee.ToString(),
                employee.GetMinimumSalary().ToString()));
            }
            Console.WriteLine();
            #endregion Liskov Substitution Principle
           

            #region Interface Segregation Principle
            Console.WriteLine("Interface Segregation Principle : - ");
            ReactDeveloper R = new ReactDeveloper();
            R.HandleFrontend();
            NodeDeveloper N = new NodeDeveloper();
            N.HandleBackend();
            Fullstackdeveloper F = new Fullstackdeveloper();
            F.HandleBackend();
            F.HandleFrontend();
            Console.WriteLine();
            #endregion Interface Segregation Principle
            
            #region Dependency Inversion Principle
            Console.WriteLine("Dependency Inversion Principle : - ");
            IAutomobile A = new Car();
            AutomobileController C = new AutomobileController(A);
            C.Displaywheel();
            IAutomobile B = new Bike();
            AutomobileController C1 = new AutomobileController(B);
            C1.Displaywheel();
            #endregion Dependency Inversion Principle
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_7
{
    /*  its an example of Liskov substitution Principle which says that the derived classes 
        should be perfectly substitutable for their base classes, here in this example there are 3 type of employees 
        permanent, temporary and contract so the bonus can only be applicable to permanent and temporary and not for 
        contact one so have created an interface which takes minimum salary for Iemployee and a bonus interface which 
        calculate bonus and required class will implement the functionality which its applicable to*/
    
    
    //interface having common methods which apply to all employees
    interface IEmployee
   {
        int ID { get; set; }
        string Name { get; set; }
        decimal GetMinimumSalary();
   }
    //interface for employee bonus
   interface IEmployeeBonus
   {
        decimal CalculateBonus(decimal salary);
   }
    //abstract class for all types of employee implements IEmployee, IEmployeeBonus
    public abstract class Employee : IEmployee, IEmployeeBonus
   {
        public int ID { get; set; }

        public string Name { get; set; }
        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }

        public abstract decimal CalculateBonus(decimal salary);
        public abstract decimal GetMinimumSalary();
   }
    //Permanent class get all the benefit of bonus so it implements empolyee
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee(int id, string name) : base(id, name)
        { }
        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .1M);
        }

        public override decimal GetMinimumSalary()
        {
            return 15000;
        }
    }
    //Temporary class get all the benefit of bonus so it implements empolyee
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(int id, string name) : base(id, name)
        { }
        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .05M);
        }

        public override decimal GetMinimumSalary()
        {
            return 5000;
        }
    }
    //Contract class will only implement IEmployee as they are not applicable for bonus
    public class ContractEmployee : IEmployee
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public ContractEmployee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public decimal GetMinimumSalary()
        {
            return 5000;
        }
        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }
}

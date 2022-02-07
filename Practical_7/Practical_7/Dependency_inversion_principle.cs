using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_7
{
    /*its an example of Dependency inversion Principle which says that there should 
     be a layer of abstraction between high level and low level modules as code should be loosely coupled */


    //High level module
    public class AutomobileController
    {
        private IAutomobile automobile;

        public AutomobileController(IAutomobile automobile)
        {
            this.automobile = automobile;
        }
        public  void Displaywheel()
        {
            Console.WriteLine(automobile.wheels());
        }
    }
    //interface or a type of abstraction between high level and low level module
    public interface IAutomobile
    {
        string wheels();
    }
    //Low level module
    public class Bike : IAutomobile
    {
        public string wheels()
        {
            return "Bike has 2 wheels";
        }
    }
    public class Car : IAutomobile
    {
        public string wheels()
        {
            return "Car has 4 wheels";
        }
    }
}

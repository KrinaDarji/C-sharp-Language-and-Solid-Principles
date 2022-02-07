using System;

namespace Prac3_polymorphism
{
    class Bird
    {

        public virtual void Voice()
        {
            Console.WriteLine("Turr Turr");
        }
        
    }
    class Duck:Bird
    {
        public override void Voice()
        {
            Console.WriteLine("Quack Quack");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Bird myBird = new Bird();
            Duck myDuck = new Duck();
            myBird.Voice();
            myDuck.Voice();
           
            Bird Mybird = new Duck(); //Downcasting of objects
            Duck MyDuck = (Duck)Mybird;//upcasting of objects
            Mybird.Voice();
            MyDuck.Voice();
            
        }
    }
}

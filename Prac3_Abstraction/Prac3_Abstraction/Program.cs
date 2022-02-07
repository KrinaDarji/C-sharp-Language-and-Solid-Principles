using System;

namespace Prac3_Abstraction
{
    //creating class Laptop
     class Laptop
    {
        //declaring variable brand and model
        private string brand;
        private string model;
        //getting and setting brand name
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        //getting and setting model name
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        /// <summary>
        /// printing brand and model name
        /// </summary>
        public void LaptopDetails()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
        }
        //hiding motherboardinfo using private keyword and hence cannot be accessed in main method
        private void MotherBoardInfo()
        {
            Console.WriteLine("MotherBoard Information");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Laptop lap = new Laptop();
            lap.Brand = "HP";
            lap.Model = "xyz";
            lap.LaptopDetails();
            
        }
    }
}

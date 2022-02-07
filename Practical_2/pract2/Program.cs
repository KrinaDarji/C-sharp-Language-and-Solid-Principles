using System;

namespace pract2
{
    class Customer_Account
    {
        //declaring variables bank name, account number, and customer name
       public string bank_name;
       public long customer_accountNo;
       public string customer_name;

        //parameterized constructor
        public Customer_Account(int accountNo,string customerName)
        {
            customer_accountNo = accountNo;
            customer_name = customerName;
        }
        /// <summary>
        /// print method
        /// </summary>
        public void printinfo()
        {
            Console.WriteLine($"Bank Name : { bank_name}");
            Console.WriteLine($"Customer Account Number : {customer_accountNo}");
            Console.WriteLine($"Customer Name : { customer_name}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer_Account cust = new Customer_Account(500,"Krina");
            cust.bank_name = "UCO"; //initializing bank name
            cust.printinfo();    
        }
    }
}

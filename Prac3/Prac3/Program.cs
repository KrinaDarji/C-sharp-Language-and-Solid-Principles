using System;

namespace Prac3
{
    //creating class sponsor 
    class Sponsor
    {
        //declaring variable with protected access specifier
        protected string owner = "Rakuteen";
    }
    // new class team extends sponsor
    class Team : Sponsor
    {
        private string teamname="krina";
       /// <summary>
       /// prints owner and teamname
       /// </summary>
       /// <returns>string</returns>
        public string printinfo()
        {
            return "Owner is " +owner+ "Team name is " +teamname;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           Team sp = new Team();
           Console.WriteLine( sp.printinfo());
        }
    }
}

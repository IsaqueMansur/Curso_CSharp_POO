using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Up_DownCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Upcasting
            Contribuitor contribuitor = new Contribuitor("Isaque", 1000);
            People people = contribuitor;
            people.printName();

            //Downcasting
            Contribuitor contribuitor2 = new Contribuitor("Manoel", 2000);
            People people2 = contribuitor2;
            Contribuitor contribuitor3 = (Contribuitor)people2;
            contribuitor3.printWage();

            Console.ReadKey();
        }
    } 
}

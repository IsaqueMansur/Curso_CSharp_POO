using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticEThis
{
    public class People
    {
        private string name;

        public People(string name) 
        {
            this.name = name;
        }
        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }
        public void printName()
        {
            Console.WriteLine(this.name);
        }
    }

    public class Calculator
    {
        public static double PI = 3.1415;
        public static double CalculateCircunferenceArea(double pRay)
        {
            return PI * Math.Pow(pRay, 2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            People people1 = new People("Isaque");
            People people2 = new People("José");
            people1.printName();

            Console.WriteLine("O valor de PI é: " + Calculator.PI);
            Console.WriteLine("A área é: " + Calculator.CalculateCircunferenceArea(2));

            Console.ReadKey();
        }
    }
}

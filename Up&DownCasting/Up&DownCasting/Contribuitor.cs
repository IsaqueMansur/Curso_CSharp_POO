using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Up_DownCasting
{
    internal class Contribuitor: People
    {
        private uint wage;

        public void printWage()
        {
            Console.WriteLine("O salário de " + Name + " é: " + this.wage);
        }
        public Contribuitor(string name, uint wage):base(name)
        {
            this.wage = wage;
        }
    }
}

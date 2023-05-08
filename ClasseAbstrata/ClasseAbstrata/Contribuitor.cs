using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    internal class Contribuitor: People
    {
        private UInt32 wage;

        public Contribuitor(string name, UInt32 wage) : base(name)
        {
            this.wage = wage;
        }

        public UInt32 Wage
        {
            get { return wage; }
            set { this.wage = value; }
        }

        public void ReadWage()
        {
            Console.WriteLine("O salário do funcionário " + Name  + " é: " + this.wage);
        }
    }
}

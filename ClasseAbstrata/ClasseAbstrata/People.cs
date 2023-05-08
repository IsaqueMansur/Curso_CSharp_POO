using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    internal abstract class People
    {
        private string name;

        public People(string name)
        {
            this.name = name;
        }

        public string Name 
        { 
            get { return name; } 
            set { this.name = value; } 
        } 

        public void ReadName()
        {
            Console.WriteLine("O nome da pessoa é: " + this.name);
        }

    }
}

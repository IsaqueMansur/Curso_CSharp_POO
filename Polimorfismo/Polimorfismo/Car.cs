using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Car:Vehicle
    {

        public void Run()
        {
            base.Run();
            Console.WriteLine("O carro está andando");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contribuitor joao = new Contribuitor("João", 1000);
            joao.ReadName();
            joao.ReadWage();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Car: IVehicle
    {
        public void PowerOn()
        {
            Console.WriteLine("Veículo ligado");
        }
        public void PowerOff() 
        { 
            Console.WriteLine("Veículo desligado");
        }
        public void OpenDoor()
        {
            Console.WriteLine("Porta aberta");
        }
       public void CloseDoor() 
        {
            Console.WriteLine("Porta fechada");
        }
    }
}

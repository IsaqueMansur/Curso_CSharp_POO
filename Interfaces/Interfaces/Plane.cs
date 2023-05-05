using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Plane : IVehicle
    {
        public void PowerOn()
        {
            Console.WriteLine("Avião ligado");
        }
        public void PowerOff()
        {
            Console.WriteLine("Avião desligado");
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

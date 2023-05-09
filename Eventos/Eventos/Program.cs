using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitchen kitchen1 = new Kitchen();
            Kitchen kitchen2 = new Kitchen();

            Tablet joao = new Tablet("João", kitchen1);
            Tablet ze = new Tablet("Zé", kitchen1);

            Tablet pedro = new Tablet("Pedro", kitchen2);
            Tablet caca = new Tablet("Caca", kitchen2);

            kitchen1.SendMessageOrderReady(40003);
            kitchen2.SendMessageOrderReady(40004);

            Console.ReadKey();
        }
    }
}

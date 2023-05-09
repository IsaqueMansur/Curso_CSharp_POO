using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    internal class Tablet
    {
        private string userName;

        public void RenderMessageOrderReady(object font, EventArgsOrderReady e)
        {
            Console.WriteLine("Pedido " + e.OrderNumber +  " pronto na cozinha ! " + userName);

        }

        public Tablet(string name, Kitchen kitchen)
        {
            this.userName = name;
            kitchen.MessageOrderAreReady += RenderMessageOrderReady;
        }
    }
}

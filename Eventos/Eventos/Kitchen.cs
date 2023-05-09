using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    internal class Kitchen
    {
        public delegate void MessageOrderAreReadyEventHandler(object font, EventArgsOrderReady e);
        public event MessageOrderAreReadyEventHandler MessageOrderAreReady;

        public void SendMessageOrderReady(UInt32 orderNumber)
        {
            if (MessageOrderAreReady != null)
            {
                EventArgsOrderReady e = new EventArgsOrderReady(orderNumber);
                MessageOrderAreReady(this, e);
            }
        }
    }
}

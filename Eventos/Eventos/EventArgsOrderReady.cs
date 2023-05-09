using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    internal class EventArgsOrderReady: EventArgs
    {
        private UInt32 orderNumber;

        public UInt32 OrderNumber
        { get { return orderNumber; } }

        public EventArgsOrderReady(UInt32 orderNumber)
        {
            this.orderNumber = orderNumber;
        }
    }
}

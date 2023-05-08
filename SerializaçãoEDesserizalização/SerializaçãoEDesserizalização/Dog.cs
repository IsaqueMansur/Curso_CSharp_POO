using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SerializaçãoEDesserizalização
{
    [DataContract]
    internal class Dog
    {
        [DataMember]
        public string name;
        [DataMember]
        public string color;

        public Dog(string name, string color) 
        {
            this.name = name;
            this.color = color;
        }
        public Dog()
        {

        }

    }
}

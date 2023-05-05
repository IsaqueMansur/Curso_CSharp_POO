using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Internal - Só poderá acessada neste software
//  Private - Só poderá acessada no bloco onde criada (só pode ser criada dentro de outras classes)
//  Public - Poderá ser acessada em qualquer lugar do software ou por outros softwares

namespace AcessoAsClasses
{
    internal class Car_Int
    {
        Car_Pub carPublic = new Car_Pub();
    }
    public class Car_Pub
    {
        Car_Int carInternal = new Car_Int();
    }
    internal class Program  
    {
        private class Car_Priv
        {

        }
        static void Main(string[] args)
        {
            Car_Int carInternal = new Car_Int();
            Car_Priv carPrivate = new Car_Priv();
            Car_Pub carPublic = new Car_Pub();
            CarroExterno externalCar = new CarroExterno();
        }
    }
}

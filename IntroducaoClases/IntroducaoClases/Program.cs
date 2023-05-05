using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoClases
{
    internal class Program
    {
        public class Car
        {
            private string creator;
            private string model;
            private UInt32 velocity;
            private bool on;

            public string Creator
            {
                get { return creator; }
                set { creator = value; }
            }
            public string Model
            {
                get { return model; }
                set { model = value; }
            }
            public UInt32 Velocity
            {
                get { return velocity; }
                set { velocity = value; }
            }
            public bool On
            {
                get { return on; }
                set { on = value; }
            }

            public void TurnOn()
            {
                on = true;
                Console.WriteLine("Carro ligado");
            }
            public void TurnOff()
            {
                on = false;
                Console.WriteLine("Carro desligado");
            }
            public void speedUp(UInt32 finalVelocity)
            {
                if (on)
                {
                    velocity = finalVelocity;
                    Console.WriteLine("Nova velocidade: " + velocity);
                }
            }
            public void stopCar()
            {
                if (velocity > 0)
                {
                    velocity = 0;
                    Console.WriteLine("Veículo parado");
                }
            }
        }
        static void Main(string[] args)
        {
            Car compass = new Car();
            compass.Creator = "Jeep";
            compass.Model = "Compass 2023";
            compass.TurnOn();
            compass.speedUp(70);
            compass.stopCar();
            compass.TurnOff();


            Console.ReadKey();
        }
    }
}

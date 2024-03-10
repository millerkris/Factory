using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public class PassengerCar : Car
    {
        public PassengerCar(string name = "PassengerCar", int maxSpeed = 120, int acceleration = 15, int braking = 15) : base(name, maxSpeed, acceleration, braking) { }

        public override void Acceleration()
        {
            if (Speed < maxSpeed)
            {
                Speed += acceleration;
            }
            else
            {
                Braking();
            }
        }
        public override void Braking()
        {
            Speed -= braking;
        }
        public override int Move(int finish)
        {
            int coint = 0;
            while (Distance < finish)
            {
                Acceleration();
                Distance += Speed / 60;
                Console.WriteLine($"{name} - Speed: {Speed}, Distance: {Distance}");
                coint++;
                if (Speed == 80)
                {
                    Distance += Speed / 60;
                    coint++;
                }
            }
            return coint;
        }
    }
}

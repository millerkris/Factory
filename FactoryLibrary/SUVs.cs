using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public class SUVs : Car
    {
        public SUVs(string name = "SUV", int maxSpeed = 150, int acceleration = 15, int braking = 10) : base(name, maxSpeed, acceleration, braking) { }

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
                if (Speed == maxSpeed)
                {
                    int n = 0;
                    while (n < 3)
                    {
                        Distance += Speed / 60;
                        coint++;
                        n++;
                    }  
                }
                coint++;
            }
            return coint;
        }
    }
}

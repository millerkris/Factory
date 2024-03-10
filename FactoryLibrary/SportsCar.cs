using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public class SportsCar: Car
    {
        public SportsCar(string name="Sports car", int maxSpeed=200, int acceleration=20, int braking=20) : base (name, maxSpeed, acceleration, braking) { }

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
                Distance += Speed /60;
                Console.WriteLine($"{name} - Speed: {Speed}, Distance: {Distance}");
                coint++;
            }
            return coint;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public class DistanseRace: Race
    {
        public override void TopPlaces(Car car1, Car car2, Car car3, int distance)
        {
            double first, second, third;

            first = car1.Move(distance);
            second = car2.Move(distance);
            third = car3.Move(distance);

            if (first > second && first > third)
            {
                Console.WriteLine($"{car1.name} занимает 3-е место");
                if(second > third)
                {
                    Console.WriteLine($"{car3.name} занимает 1-е место");
                    Console.WriteLine($"{car2.name} занимает 2-е место");
                }
                else
                {
                    Console.WriteLine($"{car2.name} занимает 1-е место");
                    Console.WriteLine($"{car3.name} занимает 2-е место");
                }
            }
            else if (first < second && first < third)
            {
                Console.WriteLine($"{car1.name} занимает 1-е место");
                if (second > third)
                {
                    Console.WriteLine($"{car3.name} занимает 2-е место");
                    Console.WriteLine($"{car2.name} занимает 3-е место");
                }
                else
                {
                    Console.WriteLine($"{car2.name} занимает 2-е место");
                    Console.WriteLine($"{car3.name} занимает 3-е место");
                }
            }
            else if(first > second && first < third)
            {
                Console.WriteLine($"{car1.name} занимает 2-е место");
                Console.WriteLine($"{car2.name} занимает 1-е место");
                Console.WriteLine($"{car3.name} занимает 3-е место");
            }
            else if(first < second && first > third)
            {
                Console.WriteLine($"{car1.name} занимает 2-е место");
                Console.WriteLine($"{car2.name} занимает 3-е место");
                Console.WriteLine($"{car3.name} занимает 1-е место");
            }
        }
    }
}

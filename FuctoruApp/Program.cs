using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryLibrary;

namespace FuctoruApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new SportsCar();
            Car car2 = new SUVs();
            Car car3 = new PassengerCar();

            Race race= new DistanseRace();

            race.TopPlaces(car1, car2, car3, 100);

            Console.ReadLine();
        }
    }
}

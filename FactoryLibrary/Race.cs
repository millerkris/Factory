using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FactoryLibrary
{
    public abstract class Race
    {

        public Race() { }

        public abstract void TopPlaces(Car car1, Car car2, Car car3, int distanse);
    }
}

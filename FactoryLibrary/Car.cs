using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary
{
    public abstract class Car
    {
        public string name;
        public int acceleration;
        public int braking;
        public int maxSpeed;

        public int Distance { get; set; }
        public int Speed { get; set; }


        public Car(string name, int maxSpeed,int acceleration, int braking ) 
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
            this.acceleration = acceleration;
            this.braking = braking;
        }

        abstract public void Acceleration();
        abstract public void Braking();
        abstract public int Move(int finish);


    }
}

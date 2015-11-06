using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Car
    {
        public readonly int maxSpeed;
        public readonly int minSpeed; 
        public Car()
        {
            maxSpeed = 55;
            minSpeed = 0;
        }

        public Car(int max)
        {
            maxSpeed = max;
            minSpeed = 0;
        }

        public Car(int max, int min)
        {
            maxSpeed = max;
            minSpeed = min;
        }

        private int currentSpeed;

        public int Speed
        {
            get { return currentSpeed; }
            set
            {
                currentSpeed = value;
                if (currentSpeed > maxSpeed)
                {
                    currentSpeed = maxSpeed;
                }

                
            }
        }
    }
}

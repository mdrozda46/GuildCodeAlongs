using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(80);

            myCar.Speed = 50;
            Console.WriteLine("My car is going {0} MPH", myCar.Speed);

            MiniVan myVan = new MiniVan();
            myVan.Speed = 10;
            Console.WriteLine("My van is going {0} MPH", myVan.Speed);


            List<Car> myCars = new List<Car>();
            for (int i = 40; i < 90; i++)
            {
               myCars.Add(new MiniVan(i)); 
            }

            foreach (Car c in myCars)
            {
                Console.WriteLine("My car is going {0} MPH", c.maxSpeed);
            }
            Console.ReadLine();
        }
    }
}

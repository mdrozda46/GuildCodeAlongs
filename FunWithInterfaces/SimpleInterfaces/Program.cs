using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Chihuahua smallDog = new Chihuahua();
            GermanShepard bigDog = new GermanShepard();
            
            Console.WriteLine(smallDog.GoForAWalk());
            Console.WriteLine(bigDog.GoForAWalk());
            
            Bark(smallDog);
            Bark(bigDog);

            Console.ReadLine();
        }

        public static void Bark(IDog dog)
        {
            dog.Bark();
        }
    }
}

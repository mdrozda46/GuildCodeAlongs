﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateTimeWednesdays
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.Write("What date would you like to start with ex. mm/dd/yyyy: ");
            string dateInput = Console.ReadLine();
            DateTime d1 = DateTime.Parse(dateInput);

            Console.Write("How many Wednesdays would you like to print?");
            string numInput = Console.ReadLine();
            int numWednesdays = int.Parse(numInput);

            while (d1.DayOfWeek != DayOfWeek.Wednesday)
            {
                d1 = d1.AddDays(1);
            }

            for (int i = 0; i < numWednesdays; i++)
            {
                Console.WriteLine(d1.ToString());
                d1 = d1.AddDays(7);
            }

            Console.ReadLine();
        }
    }
}

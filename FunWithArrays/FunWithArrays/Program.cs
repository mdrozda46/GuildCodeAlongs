using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            //prog.IterateString();
            //prog.SplitString();
            //prog.SimpleArray();
            prog.ReverseString();

            Console.ReadLine();
        }

        public void IterateString()
        {
            string s1 = "This is a string of characters.";

            foreach (char c in s1)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("The character index 3 is {0}", s1[3]);
            Console.WriteLine("The length of s1 is {0}", s1.Length);
        }

        public void SplitString()
        {
            string[] words = "This is a sentence.".Split(' ');

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
        }

        public void SimpleArray()
        {
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;

            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
        }

        public void ReverseString()
        {
            Console.WriteLine("Enter a string to be reversed: ");
            string userInput = Console.ReadLine();
            char[] userInputCharsArrays = userInput.ToCharArray();

            for (int i = 0; i < userInputCharsArrays.Length; i++)
            {
                Console.Write(userInputCharsArrays[(userInputCharsArrays.Length-1) - i]);
            }
        }

            
    }
}

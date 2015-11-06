using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExamples.Collections
{
    public class NonGenerics
    {
        public static void ShowArrayList()
        {
            ArrayList intList = new ArrayList();
            intList.Add(1);
            intList.Add(5);
            intList.Add(10);
            intList.Add(4);

            foreach (object o in intList)
            {
                Console.WriteLine((int) o);
                }
        }

        public static void ShowHashTable()
        {
            Hashtable applicationMap = new Hashtable();
            applicationMap.Add("txt", "notepad.exe");
            applicationMap.Add("bmp", "paint.exe");
            applicationMap.Add("jpg", "paint.exe");
            applicationMap.Add("docx", "word.exe");

            foreach (var key in applicationMap.Keys)
            {
                Console.WriteLine((applicationMap[key]));
            }

            string extension;

            do
            {
                Console.Write("Enter an extension");
                extension = Console.ReadLine();

                
            } while (!applicationMap.ContainsKey(extension));

            Console.WriteLine("For extension {0} your value is {1}", extension, applicationMap[extension]);

        }

        public static void ShowStack()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(myStack.Pop());
            }
        }

        public static void ShowQueue()
        {
            Queue myQueue = new Queue(); 
            myQueue.Enqueue("Hello");
            myQueue.Enqueue("World");
            myQueue.Enqueue("!");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
        }
    }
}

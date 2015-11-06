using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CollectionExamples.Collections
{
    class Generics
    {
        public void MakeStack()
        {
            Stack<Person> stack = new Stack<Person>();

            stack.Push(new Person { FirstName = "Homer", LastName = "Simpson", ID = 1});
            stack.Push(new Person { FirstName = "Marge", LastName = "Simpson", ID = 2});
            stack.Push(new Person { FirstName = "Bart", LastName = "Simpson", ID = 3});

            Person simpson;

            for (int i = 0; i < 3; i++)
            {
                simpson = stack.Pop();
                Console.WriteLine("{0}, {1}", simpson.LastName, simpson.FirstName);
            }
        }

        public void MakeQueue()
        {
            Queue<Person> myQueue = new Queue<Person>();

            myQueue.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", ID = 1 });
            myQueue.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", ID = 2 });
            myQueue.Enqueue(new Person { FirstName = "Bart", LastName = "Simpson", ID = 3 });

            Person simpson;

            simpson = myQueue.Peek();

            while (myQueue.Count != 0 )
            {
                simpson = myQueue.Dequeue();
                Console.WriteLine("{0}, {1}", simpson.LastName, simpson.FirstName);
            }

            /*for (int i = 0; i < 3; i++)
            {
                simpson = myQueue.Dequeue();
                Console.WriteLine("{0}, {1}", simpson.LastName, simpson.FirstName);
            }*/
        }

        public void SimpleList()
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.AddRange(new int[] {5,6,7,8});
            numbers.Insert(2, 100);

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            numbers.Remove(6);
            numbers.RemoveRange(1,2);
            numbers.RemoveAt(2);
        }
    }
}

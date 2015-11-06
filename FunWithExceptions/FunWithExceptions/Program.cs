using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithExceptions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //CauseException();
            //HandleException();
            //HandleSpecificException();
            //FinallyExample();
            //CallStackExample();
            ThrowCustomException();

            Console.ReadLine();
        }

        private static void CauseException()
        {
            int x = 5;
            int y = 0;

            Console.WriteLine(x/y);
        }

        private static void HandleException()
        {
            try
            {
                CauseException();
            }
            catch
            {
                Console.WriteLine("You did something bad, but I am going to keep running!");

            }
        }

        private static void HandleSpecificException()
        {
            try
            {
                int[] ints = new int[2];

                //TODO: I need to fix thi!
                ints[20] = 50;
                ints[0] = 5;
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range!");
            }

            catch
            {
                Console.WriteLine("Catch all other exceptions.");
            }
        }

        private static void FinallyExample()
        {
            try
            {
                int x = 5;
                int y = 0;

                Console.WriteLine(x/y);
            }

            catch (DivideByZeroException dex)
            {
                Console.WriteLine("Exception Occured");
                Console.WriteLine(dex.Message);
                Console.WriteLine(dex.StackTrace);
                Console.WriteLine("*************************");
            }

            finally
            {
                Console.WriteLine("In the finally!");
            }
        }

        private static void CallStackExample()
        {
            try
            {
                Method1();
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Catch clause in CallStackExample()");
            }

            finally
            {
                Console.WriteLine("Finally clause in CallStackExample()");
            }

            Console.WriteLine("Keep Running!");
        }

        static void Method1()
        {
            try
            {
                Method2();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Catch clause in Method1()");

            }
            finally
            {
                Console.WriteLine("Finally clause in Method1()");
            }
        }

        static void Method2()
        {
            try
            {
                CauseException();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Catch clause in Method2()");

            }
            finally
            {
                Console.WriteLine("Finally clause in Method2()");
            }
        }

        static void ThrowCustomException()
        {
            try
            {
                throw new MySpecificException("Not a chance.");
            }

            catch (MySpecificException mex)
            {
                Console.WriteLine(mex.Message);
                Console.WriteLine(mex.StackTrace);
                Console.WriteLine(mex.HelpLink);
            }
        }
    }
}

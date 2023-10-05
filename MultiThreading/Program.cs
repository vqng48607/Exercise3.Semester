using System.Net.NetworkInformation;

namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting in the main method");

            var t1 = new Thread(new ThreadStart(AddToList));
            t1.Start();

            var t2 = new Thread(new ThreadStart(AddToList));
            t2.Start();

            var t3 = new Thread(new ThreadStart(AddToList));
            t3.Start();

            Console.WriteLine("Ending in the main method");
        }
        private static List<int> numbers = new List<int>();
        private static void AddToList()
        {
            for(int ix = 0; ix < 100;  ix++)
            {
                numbers.Add(ix);
            }
        }

        private static Random rnd = new Random();
        private static int total = 0;

        //public static void DoWork()
        //{
        //    Thread.Sleep(rnd.Next(1, 2000));
        //    int myTotal = total;
        //    Thread.Sleep(rnd.Next(1,2000));
        //    total = myTotal+1;
        //    Console.WriteLine("Managed Thread ID: {0} says {1}", Thread.CurrentThread.ManagedThreadId, total);
        //}
    }
}
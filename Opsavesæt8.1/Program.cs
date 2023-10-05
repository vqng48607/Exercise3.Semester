using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Opsavesæt8._1
{
    internal class Program
    {
        public static int mainSum;
        public static Object key = new Object();
        static void Main(string[] args)
        {
            
            Thread t1 = new Thread(Thread);
            Thread t2 = new Thread(Thread);
            Thread t3 = new Thread(Thread);

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine(mainSum);
        }
        
        static void Thread()
        {
            
            int mySum = 0;
            Random rnd = new Random();
            int randomNumber;

            for (int i = 0; i < 1000; i++)
            {
                
                randomNumber = rnd.Next(9);
                mySum = mySum + randomNumber;
                lock (key)
                {
                    mainSum = mainSum + randomNumber;
                }

            }

            Console.WriteLine(mySum);
        }
    }

}
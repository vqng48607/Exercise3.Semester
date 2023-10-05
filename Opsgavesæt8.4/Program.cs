namespace Opsgavesæt8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chopstick c1 = new Chopstick(1);
            Chopstick c2 = new Chopstick(2);
            Chopstick c3 = new Chopstick(3);
            Chopstick c4 = new Chopstick(4);
            Chopstick c5 = new Chopstick(5);

            Philosophers p1 = new Philosophers(1, c5, c1);
            Philosophers p2 = new Philosophers(2, c1, c2);
            Philosophers p3 = new Philosophers(3, c2, c3);
            Philosophers p4 = new Philosophers(4, c3, c4);
            Philosophers p5 = new Philosophers(5, c4, c5);

            Thread t1 = new Thread(() => Eat(p1));
            Thread t2 = new Thread(() => Eat(p2));
            Thread t3 = new Thread(() => Eat(p3));
            Thread t4 = new Thread(() => Eat(p4));
            Thread t5 = new Thread(() => Eat(p5));

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();

            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();

        }

        public static void Eat(Philosophers philosophers)
        {
            string message = "";

            lock (philosophers.LeftChopstick)
            {
                lock (philosophers.RightChopstick)
                {
                    philosophers.IsEating = true;
                    message = $"{philosophers.Id} is eating";
                    Console.WriteLine(message);
                    Thread.Sleep(1000);

                    message = $"{philosophers.Id} is sleeping";
                    Console.WriteLine(message);
                    philosophers.IsEating = false;
                }
            }



        }
    }
}
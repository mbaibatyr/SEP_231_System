using Microsoft.Data.SqlClient;

namespace MySync
{
    internal class Program
    {
        static object locker = new();
        static void Main(string[] args)
        {
            
            DateTime dt = DateTime.Now;
            for (int i = 0; i < 3; i++)
            {
                Thread t = new Thread(Test);
                Thread t2 = new Thread(() => Console.WriteLine("adasdasd"));
                Thread t3 = new Thread(new ThreadStart(Test));
                t2.Start();                
                t.Name = "Поток " + i.ToString();
                t.Start();
            }
            var span = (DateTime.Now - dt).TotalSeconds;

            Thread.Sleep(5000);
            Console.WriteLine(span);
            //Console.ReadLine();
        }

        static void Test()
        {
            lock (locker)
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(i + " - " + Thread.CurrentThread.Name);
                }
            }
        }
       
    }
}
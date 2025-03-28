namespace MyThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test_1();
            //var curT = Thread.CurrentThread;
            //Console.WriteLine(curT.Name);
            //Console.WriteLine(curT.ManagedThreadId);
            //Console.WriteLine(curT.IsAlive);
            //Console.WriteLine(curT.Priority);            
            

            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(Test_1);
                thread.Name = "t" + i.ToString();
                thread.Start();
            }
            Console.ReadLine();            
        }

        static void Test_1()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine($"{i} - {Thread.CurrentThread.Name}");
            }
        }
    }
}
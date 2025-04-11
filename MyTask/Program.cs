namespace MyTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method1();


            var count = Method1().Result;
            //var count = Method1().GetAwaiter().GetResult();
            Console.WriteLine(count.ToString());
            //await Method1();


            //Method2();
            //Method2();            
            //Console.ReadKey();            

        }

        static void Test()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine($"{i} - {Thread.CurrentThread.ManagedThreadId}");
            }
        }

        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Method 1_1");                    
                    count++;
                    Task.Delay(100).Wait();
                }
            });
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(" Method 1_2");
                    count++;
                    Task.Delay(100).Wait();
                }
            });
            await Task.Run(Method2);
            Console.WriteLine(" FINISH ");
            return count;
        }
        static void Method2()
        {
            Task.Delay(1000).Wait();
            Console.WriteLine(" Method 2");
            
        }
    }
}
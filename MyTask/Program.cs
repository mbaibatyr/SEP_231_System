namespace MyTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks = new Task[5];
            for (int i = 0; i < 5; i++)
            {
                tasks[i] = new Task(Test);
                tasks[i].Start();
                
                Console.WriteLine(Task.CurrentId);
            }

            Task.WaitAll(tasks);

            //Console.WriteLine("Start");
            //Task t = new Task(Test);
            //t.Start();
            //t.Wait();
            Console.WriteLine("Finish");

        }

        static void Test()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine($"{i} - {Thread.CurrentThread.ManagedThreadId}");
            }
        }
    }
}
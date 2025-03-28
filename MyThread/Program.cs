namespace MyThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dt1 = DateTime.Now;
            Calc();
            var span = (DateTime.Now - dt1);
            Console.WriteLine(span.TotalSeconds);
            return;


            //Test_1();
            //var curT = Thread.CurrentThread;
            //Console.WriteLine(curT.Name);
            //Console.WriteLine(curT.ManagedThreadId);
            //Console.WriteLine(curT.IsAlive);
            //Console.WriteLine(curT.Priority);            


            //for (int i = 0; i < 10; i++)
            //{
            //    Thread thread = new Thread(Test_1);
            //    thread.Name = "t" + i.ToString();
            //    thread.Start();

            //    //Thread th = new Thread(() => Console.WriteLine(i + " ---"));
            //    //th.Start();

            //    //Thread th = new Thread(new ThreadStart(Test_1));
            //    //th.Start();

            //}

            //Thread thread = new Thread(Test_2);
            //thread.Start(5);
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

        static void Test_2(object ob)
        {
            for (int i = 0; i < int.Parse(ob.ToString()); i++)
            {
                Thread.Sleep(100);
                Console.WriteLine($"{i} - {Thread.CurrentThread.Name}");
            }
        }

        static void Calc()
        {
            var lines = File.ReadAllLines(@"\\file-server\Share\Временные файлы\SEP-231\001.txt");
            double sum = 0;
            foreach (string line in lines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    sum += int.Parse(line[i].ToString());
                }
            }
            Console.WriteLine(sum);
        }
    }
}
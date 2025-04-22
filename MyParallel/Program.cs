using System.Net;

namespace MyParallel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DownloadFile("https://portal.ksu.edu.kz/storage/app/media/docs/laws/resolutions/constitution_rk_rus.pdf");

            var numbers = Enumerable.Range(1, 1000000000);

            var evenNumbers = numbers.AsParallel()
                                      .WithDegreeOfParallelism(2)
                                      .Where(n => n % 2 == 0)
                                      .ToList();

            Console.WriteLine($"четных чисел {evenNumbers.Count}");
            return;

            Console.WriteLine("Started");
            //Parallel.Invoke(
            //    ()=> Console.WriteLine(Task.CurrentId),
            //    () => Console.WriteLine(Task.CurrentId),
            //    Method_1
            //    );

            //Parallel.For(1, 10, i =>
            //{
            //    //Console.WriteLine(i);
            //    Method_2(i);
            //});

            List<string> lst = new List<string>() { "111", "222", "333", "444" };

            ParallelOptions opt = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 20,
            };
            Parallel.ForEach(lst, opt, (z, state) =>
            {

                if (z == "333")
                {
                    Console.WriteLine("333 break");
                    state.Stop();
                }
                else
                {
                    Method_3(z);
                }
            });

            Console.WriteLine("Finished");

        }

        static void Method_1()
        {
            //Thread.Sleep(2000);
            Console.WriteLine("Method_1 " + Task.CurrentId);
        }

        static void Method_2(int i)
        {
            Console.WriteLine($"{i} = {i * i}");
        }

        static void Method_3(string st)
        {
            //Thread.Sleep(2000);
            Console.WriteLine("Method_3 " + st + " " + Task.CurrentId);
        }

        static void DownloadFile(string path)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    var sections = path.Split('/');
                    var name = sections[sections.Length - 1];

                    client.DownloadFile(path, $@"C:\Users\байбатыровм\Documents\Files\{name}");
                    Console.WriteLine("Файл скачался");
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }
    }
}
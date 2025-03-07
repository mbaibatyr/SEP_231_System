using System.Diagnostics;

namespace SEP_231_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var p = Process.GetProcesses()
            //    .Where(z=>z.ProcessName == "notepad");
            //foreach (var item in p)
            //{                
            //    Console.WriteLine($"{item.ProcessName}");
            //}

            //var p = from n in Process.GetProcesses()
            //        where n.ProcessName == "notepad"
            //        select n;
            //    .Where(z=>z.ProcessName == "notepad");            

            //var p = Process.GetProcessesByName("notepad");
            //if (p != null && p.Length > 0)
            //{
            //    //Console.WriteLine($"{p[0].StartTime}");
            //    foreach (ProcessModule item in p[0].Modules)
            //    {
            //        Console.WriteLine($"{item.FileName}");                    
            //    }
            //}

            var p = Process.Start("notepad");
            Console.WriteLine(p.Id);

        }
    }
}
using System.Diagnostics;

namespace SEP_231_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = Process.GetProcesses();
            foreach (var item in p)
            {
                Console.WriteLine($"{item.ProcessName}");
            }
        }
    }
}
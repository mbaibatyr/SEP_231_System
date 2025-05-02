namespace MyTimer
{
    internal class Program
    {
        static System.Timers.Timer timer;
        static System.Threading.Timer timer2;
        
        static int count = 1;
        static void Main(string[] args)
        {
            //timer = new System.Timers.Timer();
            //timer.Interval = 1000 * 1;
            //timer.Elapsed += Print;
            //timer.Elapsed += Print;
            //timer.Start();

            timer2 = new Timer(Print, null, 0, 1000);

            Console.WriteLine($"{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")} - {count++}");

            Console.ReadLine();            
        }

        static void Print(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine($"{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")} - { count++}");
            if (count > 5)
            {
                //timer.Stop();                
                //timer.Elapsed -= Print;
            }
        }

        static void Print(object state)
        {
            Console.WriteLine($"{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")} - {count++}");
            if (count > 5)
            {                
                timer2.Dispose();             
            }
        }

    }
}
namespace MyDLL
{

    interface ITest
    {
        public void GetValue();
    }
    public class MyClass
    {
        public MyClass(){}
        public MyClass(string st)
        {
            ;
        }
        public string Name { get; set; }
        private string Title { get; set; }
        string Street;
        public int GetSum(int a, int b)
        {
            return a + b;
        }

        public string SayHello(string Name)
        {
            return "Hello " + Name;
        }

        public static string SayHello2(string Name)
        {
            return "Hello2 " + Name;
        }
    }
}
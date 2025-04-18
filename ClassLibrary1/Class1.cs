namespace ClassLibrary1
{
    public class Class1
    {
        public string Name { get; }
        public Class1(string name) => Name = name;
        public Class1()
        {
            ;
        }
        public Class1(int i)
        {
            ;
        }
        public Class1(int i, string st)
        {
            ;
        }

        public void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }

    public interface IClass1
    {
        int Method(string st);
        Class1 Method2(string st);
    }



}
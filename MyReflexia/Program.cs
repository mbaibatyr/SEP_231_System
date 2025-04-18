namespace MyReflexia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(Person);            

            //Console.WriteLine(myType.Assembly);
            //Console.WriteLine(myType.Name);
            //Console.WriteLine(myType.FullName);
            Console.WriteLine($"Is class: {myType.IsClass}");
            Console.ReadLine(); 

            
        }
    }
    public class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name;
        public Person()
        {
            ;
        }
        public Person(int i)
        {
            ;
        }
    }

    public interface IPerson
    {
        void SayHello(string name);
        string GetHello(string name);
        string GetHello(Person person);
        Person GetHello(int i);
    }

    public abstract class MyClass
    {
        public abstract string MyAbstract(string name);
        public virtual string MyVirtual(string name) 
        {
            return $"Hello {name}";
        }
        private static string connectionString = "hello step";
    }
}
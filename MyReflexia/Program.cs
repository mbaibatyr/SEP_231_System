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

            
        }
    }
    public class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name;
    }
}
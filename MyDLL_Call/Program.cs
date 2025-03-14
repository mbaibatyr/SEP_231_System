using MyDLL;
using System.Reflection;

namespace MyDLL_Call
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass("");
            Console.WriteLine(myClass.SayHello("step"));
            Console.WriteLine(myClass.GetSum(12, 13));
            Console.WriteLine(MyClass.SayHello2("step222"));

            string dllPath = @"C:\Users\байбатыровм\source\repos\SEP_231_System\MyDLL\bin\Debug\net6.0\MyDLL.dll";
            Assembly assembly = Assembly.LoadFrom(dllPath);
            Type type = assembly.GetType("MyDLL.MyClass");
            object instance = Activator.CreateInstance(type);
            MethodInfo SayHello = type.GetMethod("SayHello");
            var result = SayHello.Invoke(instance, new object[] { "STEPPPPP" });
            Console.WriteLine(result);
        }
    }
}
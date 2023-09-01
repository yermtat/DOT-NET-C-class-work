
using C;

using anta = Antananarivu;

using static System.Console;

namespace namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foo foo = new Foo();
            foo.Print();
            A.Foo foo1 = new A.Foo();
            foo1.Print();
            B.Foo foo2 = new B.Foo();
            foo2.Print();

            Bar bar = new Bar();

           

            Console.WriteLine("Hello, World!");
            WriteLine("Meow");
        }
    }
}

// в одном и том же неймспейсе нельзя создать класс с одинаковыми именами
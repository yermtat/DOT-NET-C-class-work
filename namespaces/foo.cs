using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespaces
{
    internal class Foo
    {

        public void Print() { Console.WriteLine("Foo 1"); }
    }
}

namespace A
{
    public class Foo
    {

        public void Print() { Console.WriteLine("Foo 2"); }
    }
}

namespace B
{
    public class Foo
    {

        public void Print() { Console.WriteLine("Foo 3"); }
    }
}

namespace C
{
    class Bar
    {

    }

}

namespace Antananarivu
{
    public class Madagascar
    {

        public void Print() { Console.WriteLine("quack"); }
    }
}

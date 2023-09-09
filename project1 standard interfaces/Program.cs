FooBar foobar = new FooBar();
foobar.Foo();

IFoo foo = new FooBar();
IBar bar = new FooBar();
bar.Foo();
foo.Foo();

((IFoo)foobar).Foo();
((IBar)foobar).Foo();

interface IFoo
{
    void Foo();
}

interface IBar
{
    void Foo();
}

class FooBar : IFoo, IBar
{
    //public void Foo()
    //{
    //    Console.WriteLine("Foo Hello, World") ;
    //}
    
    void IFoo.Foo()
    {
        Console.WriteLine("Foo Hello, World");
    }

    void IBar.Foo()
    {
        Console.WriteLine("Bar Hello, World");
    }

    public void Foo()
    {
        Console.WriteLine("Own Hello, World");
    }
}
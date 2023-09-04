using System;

Derived derived = new Derived("Salam", 13, 46);
derived.Show();
derived.DerivedFoo();
//GrandChild grand = new();
//grand.Show();

GrandChild grandChild = new();

class Base
{
    public int Field1 { get; set; }
    private int Field2;

    public Base()
    {
        Field1 = 1;
        Field2 = 2;
        Console.WriteLine("Base default constructor");
    }
    public Base(int field1, int field2)
    {
        Field1 = field1;
        Field2 = field2;
        Console.WriteLine("Base parameterized constructor");
    }

    public void Show()
    {
        Console.WriteLine($"Field1 = {Field1}, Field2 = {Field2}");
    }

    protected void Foo()
    {
        Console.WriteLine("Protected method Foo");
    }

    private void Bar()
    {
        Console.WriteLine("Private method Bar");
    }
}

class Derived : Base
{
    public string SomeProperty { get; set; }

    public Derived()
    {
        Console.WriteLine("Derived default constructor");
    }

    public Derived(string some, int field1, int field2) : base(field1, field2) // вызывает конструктор родительского класса 
    {
        SomeProperty = some;
        Console.WriteLine("Derived parameterized constructor");
    }
    public void DerivedFoo()
    {
        Foo(); // метод фу видно только внутри дочернего класса, т.к. он протектед, объектам дочернего класса этот метод не доступен

    }
}

// здесь нет множественного наследования, класс может наследоваться только от одного другого класса 

//class GrandChild : Base, Derived      // ошибка компиляции
//{

//}


sealed /*дописываем если не хотим чтобы от этого класса еще что-то наследовалось*/class GrandChild : Derived
{
    public GrandChild() : base("Hi", 36, 89)
    {
        Console.WriteLine("Grandchild default constructor");
    }

    public GrandChild(string some, int field1, int field2) : base(some, field1, field2)
    {
        Console.WriteLine("Grandchild parameterized constructor");
    }
}

//class Kolbas : Grandchild     // ошибка компиляции т.к. не может наследоваться от sealed класса
//{

//}
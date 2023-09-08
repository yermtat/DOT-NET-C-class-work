//Animal animal = new Animal();   // объект абстраткного класса создать невозможно
Farij jiraf = new Farij();
jiraf.Walk();
jiraf.Think();

Foo(jiraf);
Animal liraf = new Farij();

void Foo(Animal laminat)
{
    laminat.Walk();
}
abstract class Animal // для создания абстрактного класса достаточно указать что он абстрактный, необязательно вписывать абстрактный метод
{
    string name;

    public abstract void Walk();
    public void Think()
    {
        Console.WriteLine("Thinking........");
    }
}

class Farij : Animal
{
    public override void Walk()
    {
        Console.WriteLine("Salam popolam");
    }
}
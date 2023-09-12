
//public class Human // этот класс будет доступен везде
//{
//    public string name;
//    public string surname;
//    public int age;
//}


Human human = new Human();
human.age = 25;
Console.WriteLine();
human.Foo();
Human human2 = human;
Console.WriteLine(human.name + " " + human2.name);
human2.name = "A-tilla";
Console.WriteLine(human.name + " " +human2.name); // поменяется в обеих т.к копируется по ссылке

Human.count = 5;
Console.WriteLine(Human.count);
void Bar() // методы(они вместо функций, т.к. под капотом мейн тут класс) должны быть описаны до классов
{
    Console.WriteLine("Salam");
}


// класс не может быть прямо private, может быть private protected и тд
internal class Human // этот класс не будет доступен вне сборки
{
    // public, private, internal, protected internal (внутри сборки только самому классу и дочерним, вне сборки недоступно)
    public string name;
    public string surname;
    public int age;
    // можно иницилизровать значение здесь

    public static int count;
    public const int field1 = 25; // константные поля по умолчанию статические, должна инициализироваться при объявлении поля класса
    public readonly int field2; // можно дать значение через конструктор при создании, а дальше только использовать менять нельзя

    static Human() // статический конструктор вызывается только при первом создании объекта
    {
        // можно инициализировать только статические поля, т.к. как и в плюсах не передается this
        count = 0;

    }

    public Human() : this("Empty", "Empty", 0, 4)
    {
    }
    public Human(string name, string surname, int age, int field2)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.field2 = field2;
    }

    public void Foo()
    {
        Bambarbiya.Method(this);
    }

    public void Bar(int a, double b) { }
    public void Bar(double a, int b) { }
    public void Bar(int a, int b) { }
    public void Bar(int a) { }
}

class Bambarbiya
{
    public static void Method(Human human)
    {
        Console.WriteLine(human.name);
    }
}



// прочитать обфускацию, обфускатор. ref, out
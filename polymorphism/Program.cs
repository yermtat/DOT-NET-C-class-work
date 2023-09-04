//Base @base = new(); // если нужно использовать какое-либо ключевое слово как имя для переменной ставится @ перед переменной

Base myBase = new();
//myBase.Show();
//Console.WriteLine(myBase.Field1);
Derived derived = new();
//Console.WriteLine(derived.Field1);
//derived.Show();

Base derive = new Derived();
//Console.WriteLine(derive.Field1);
//((Derived)derive).Show();

//Foo(myBase);
//Foo(derive);
//Foo(derived);
//Foo(new Child());

//derived.Print();


//Console.WriteLine(derive); // по умолчанию вызывается ту стринг, который по умолчанию возвращает название класса, если его не переопределить

Human atilla = new("Atilla", "Ismail", 14);
Human nadir = new("Nadir", "Zamanov", 42);
var value = atilla.ToString();
Console.WriteLine(value);
Console.WriteLine(nadir);


void Foo(Base @base) 
{
    #region version 1
    //// version 1
    //if (@base.GetType() == new Derived().GetType())
    //{ 
    //    ((Derived)@base).Show();
    //}
    //if (@base.GetType() == new Child().GetType())
    //{
    //    ((Child)@base).Show();
    //}
    //else
    //{
    //    @base.Show();
    //}
    #endregion


    //try
    //{
    //    ((Derived)@base).Show();
    //}

    #region version 3
    //if (@base is Derived)
    //{
    //    ((Derived)@base).Show();
    //}
    //if (@base is Child)
    //{
    //    ((Child)@base).Show();
    //}
    //else
    //{
    //    @base.Show();
    //}
    #endregion


    #region version 4

    //var value = @base as Derived;
    //var value1 = @base as Child;
    //var value2 = @base as Base;
    //if (value != null) value.Show();
    //if (value1 != null) value.Show();
    //if (value2 != null) value.Show();
    #endregion

    @base.Show();

}

class Base
{
    public string Field1 { get; set; } = "Salam";
    public virtual void Show()
    {
        Console.WriteLine("Base class show");
    }
}

class Derived : Base
{
    public new string Field1 { get; set; } = "Popolam";
    public override void Show()
    {
        Console.WriteLine("Derived class show");
    }

    public void Print()
    {
        Console.WriteLine(Field1);
        base.Show();
    }

    public override string ToString()
    {
        return "nya";
    }
}


class Child : Base
{
    public override void Show()
    {
        Console.WriteLine("Child class show");
    }
    
}


class Human
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public Human(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public override string ToString()
    {
        return $@"Name: {Name} 
Surname: {Surname}
Age: {Age}";
    }
}



// прочитать про интерфейсы и абстрактные классы 


//Human human = new();
//human.SetAge(-23);
//Console.WriteLine(human.GetAge);



//class Human
//{
//    public string name;
//    public string surname;
//    private int _age;

//    public int GetAge()
//    {
//        return _age;
//    }

//    public void SetAge(int age)
//    {
//        if (age < 0 || age > 150)
//        {
//            throw new ArgumentOutOfRangeException("0 ~ 150");
//        }

//        _age = age;
//    }
//}





Human human = new();
human.Age = 25;


//class Human
//{
//    public string name;
//    public string surname;

//    private int _age;

//    public int Age
//    {
//        get { return Age; }
//        set { Age = value; }
//    }
//}
class Human
{
    public string Name { get; set; } = "Empty"; // авто проперти. пишется с большой буквы, создает одно поле с прайвет переменной и второе с паблик проперти 
    public string surname;

    //public int MyProperty { get; private set;}
    public int MyProperty1 { get; set; }

 

    private int _age;

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
}


// один класс можно разделить на части и писать в разных местах


// делегаты грубо говоря - массив указателей на функцию. указатель на метод который может указывать на любой метод с такой сигнатурой (параметры и возвращаемое значение)
// cсылочный тип который хранит ссылки на методы

//public delegate int MyIntDelegate (int numb1, int numb2);

//public delegate void MyVoidDelegate(double number);

// Action, Func, Predicate


#region Delegates
//double numb1 = default, numb2 = default;

//Console.WriteLine("Enter first number: ");
//double.TryParse(Console.ReadLine(), out numb1);
//Console.WriteLine("Enter second number: ");
//double.TryParse(Console.ReadLine(), out numb2);


//char operation = default;
//Console.WriteLine("Enter operation +, -, /, *: ");
//char.TryParse(Console.ReadLine(), out operation);
//CalculatorDelegate @delegate = null;

//switch ((operations)operation)
//{
//    case operations.ADD:
//        @delegate = Sum;
//        break;
//    case operations.SUB:
//        @delegate = Substract;
//        break;
//    case operations.DIVIDE: 
//        @delegate = Divide;
//        break;
//    case operations.MULT:
//        @delegate = Multiple;
//        break;

//}


////if (@delegate is not null) Console.WriteLine(@delegate(numb1, numb2));
//if (@delegate is not null) Console.WriteLine(Calculator(numb1, numb2, @delegate));

//double Calculator(double numb1, double numb2, CalculatorDelegate calculator)
//{
//    return calculator(numb1, numb2);
//}

//double Sum(double left, double right)
//{
//    return left + right;
//}

//double Substract(double left, double right)
//{
//    return left - right;
//}

//double Divide(double left, double right)
//{
//    if (right != 0) return left / right;
//    throw new DivideByZeroException();
//}

//double Multiple(double left, double right)
//{
//    return left * right;
//}

//public delegate double CalculatorDelegate(double left, double right);

//enum operations { ADD = '+', SUB = '-', DIVIDE = '/', MULT = '*'};
#endregion


#region Multicast delegate

//double numb1 = 5, numb2 = 3.5;

////CalculatorDelegate calculators = Sum;
//GenericDelegate<double> calculators = Sum;
//calculators += Substract;
////calculators -= Substract;
//calculators += Divide;
//calculators += Multiple;

////foreach (CalculatorDelegate calculator in calculators.GetInvocationList())
////{
////    Console.WriteLine(calculator(numb1, numb2));
////}

//foreach (GenericDelegate<double> calculator in calculators.GetInvocationList())
//{
//    Console.WriteLine(calculator(numb1, numb2));
//}


//double Sum(double left, double right)
//{
//    return left + right;
//}

//double Substract(double left, double right)
//{
//    return left - right;
//}

//double Divide(double left, double right)
//{
//    if (right != 0) return left / right;
//    throw new DivideByZeroException();
//}

//double Multiple(double left, double right)
//{
//    return left * right;
//}

//public delegate double CalculatorDelegate(double left, double right);


//public delegate T GenericDelegate<T>(T left, T right);

#endregion


#region Action
// Action<T>, Func<T>, Predicate<T>

// action подходит для всех методов что возвращают войд и принимает до 16 параметров

//int[] arr = new int[20];
//Random random = new Random();
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = random.Next(10, 99);
//}

//foreach (int i in arr)
//{
//    Console.Write($"{i} ");
//}
//Console.WriteLine();


//Foo(arr, ShowSquare);
//Console.WriteLine();
//Foo(arr, ShowNegative);
//void Foo(int[] arr, Action<int> action)
//{
//    foreach (var item in arr)
//    {
//        action(item);
//    }
//}

//void  ShowSquare(int numb)
//{
//    Console.Write($"{numb * numb} ");
//}

//void ShowNegative(int numb)
//{
//    Console.Write($"{-numb} ");
//}
#endregion

#region Func
//List<int> ints = new() { 1, 3, 6, 5, 8, 4, 5, 6, 98 };

//var evens = ints.Where(Even).ToList();

//evens.ForEach(Console.WriteLine);

//bool Even(int numb)
//{
//    return numb % 2 == 0;
//}
#endregion

#region predicate
//List<int> ints = new() { 1, 3, 6, 5, 8, 4, 5, 6, 98 };

//var greaterFive = ints.FindAll(GreaterThanFive).ToList();

//bool GreaterThanFive(int numb)
//{
//    return numb > 5;
//}

#endregion


using System.Globalization;
using System.Net.Cache;

List<int> ints = new() { 1, 3, 6, 5, 8, 4, 5, 6, 98 };

ints.Sort();

List<Human> humans = new()
{
    new Human {Name = "Lla", Age = 17},
    new Human {Name = "Ati", Age = 12},
    new Human {Name = "Allita", Age = 25},
    new Human {Name = "Talila", Age = 230}
};

humans.ForEach(Console.WriteLine);

humans.Sort(AgeComp);
humans.ForEach(Console.WriteLine);

int NameComp(Human a, Human b)
{
    return a.Name.CompareTo(b.Name);
}

int AgeComp(Human a, Human b)
{
    return a.Age.CompareTo(b.Age);
}

int Desc(int a, int b)
{
    return a.CompareTo(b);
}

class Human
{
    public string Name { get; set; }
    public int Age;

    public override string ToString()
    {
        return $"Name: {Name}, age: {Age}";
    }
}

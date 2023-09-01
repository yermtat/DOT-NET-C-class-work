#region arrays

//int[] numbers = new int[5] { 2, 6, 9, 8, 45 };

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.Write($"{numbers[i]} ");
//}

//string name = Console.ReadLine();
//Console.WriteLine("Welcome  " + name);
////string interpolation $"{variable or value}"
//Console.WriteLine($"Welcome {name}");


//Console.WriteLine(numbers.Rank); //показывает мерность размера (одномерный двумерный и т.д.)

//Console.WriteLine(numbers.GetUpperBound(0)); //индексы нижней и верхней границы
//Console.WriteLine(numbers.GetLowerBound(0));

//var arr = numbers;
//arr[0] = 36;
//Console.WriteLine(numbers[0]);

//numbers.Clone(); // поверхностная копия, указателей в си шарпе нет но принцип тот же: скопируется адрес изначального массива

//var new_arr = new int[] { 2, 6, 9, 8, 26 };
//Console.WriteLine(arr == numbers); // сравниваются ссылки
//Console.WriteLine(arr == new_arr);
//Console.WriteLine(arr.Equals(new_arr));

//foreach (int i in numbers)
//{

//}

#endregion

#region multidimension arrays

//int[,] mdArray = new int[2, 2] { 
//    { 5, 9 }, 
//    { 3, 45 } 
//};

//Console.WriteLine(mdArray[0, 0]);
//Console.WriteLine(mdArray.Rank);


#endregion

#region jagged arrays

//int[][] jgArray = new int[3][];
//jgArray[0] = new int[5];
//for (int i = 0; i < 3; i++)
//{
//    jgArray[0][i] = i;
//}
//jgArray[1] = new int[] { 2, 98, 69 };
//jgArray[2] = new int[2] { 25, 9 };


//for (int i = 0;i < jgArray.Length; i++)
//{
//    for (int j = 0;j < jgArray[i].Length; j++)
//    {
//        Console.Write(jgArray[i][j] + " ");
//    }
//    Console.WriteLine();
//}

//for (int i = 0; i <jgArray.GetUpperBound(0) ; i++)  // не сработает, т.к джаггед аррей существует(?) как одномерный, если посмотреть через ранк
//{
//    for (int j = 0; j < jgArray.GetUpperBound(1); j++)
//    {
//        Console.Write(jgArray[i][j] + " ");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine(jgArray.GetUpperBound(0));
#endregion

// p.s. прочитать про класс Array


namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
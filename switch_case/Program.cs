//string ch = "salam";

// не будет работать без ключевого слова брейк или гоу ту или ретерн и т.д.
// в отличие от плюсов можно использовать не только целочисленные данные, но кейсы все еще должны быть константными и не одинаковыми

//switch (ch)
//{
//    case "salam":
//        Console.WriteLine("Salam");
//        goto case "hi";
//    case "hi":
//        Console.WriteLine("Hi");
//        break;
//    default:
//        break;
//}



int value = 0;

//value = Convert.ToInt32(Console.ReadLine());

int result = 0;

//switch(value)
//{
//    case 0:
//        result = 1; 
//        break;
//     case 1: 
//        result = 2;
//        break;
//      case 2:
//        result = 3;
//        break;


//}


//result = value switch
result = Convert.ToInt32(Console.ReadLine()) switch
{
    0 => 1,
    1 => 2,
    2 => 3,
    _ => 0
};

Console.WriteLine(result);

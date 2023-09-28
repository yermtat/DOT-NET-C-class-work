// mulicast delegate

string? name = null; // ? явно указывает наллбл тип
// если ? после переменной но до точки до метода - проверка на то налл или нет
Console.WriteLine(name?.Length);

name ??= "Elvin"; // если нейм налл запиши туда эльвин


string foo(string text)
{
    return text ?? throw new ArgumentNullException(nameof(text)); // если текст налл брось эксепшн если нет ретерн налл
}

// можно скзать ?? это тернарный оператор специально для налл случаев
// структуры создаются в хипе

// дефолтный конструктор не переопределяется
Point point = new Point();
Console.WriteLine(point.x);
Console.WriteLine(point.y);
Console.WriteLine(point.bulbul);

Console.WriteLine();

Point pointBlank = new Point(25, 23, true);
//var pointBlank = new Point(25, 23, true);
Console.WriteLine(pointBlank.x);
Console.WriteLine(pointBlank.y);
Console.WriteLine(pointBlank.bulbul);

Point point1 = new(69, 89, false);
Point point2 = point1; // побитовое копирование

Console.WriteLine(point1.x);
Console.WriteLine(point1.y);
Console.WriteLine(point1.bulbul);
Console.WriteLine();
Console.WriteLine(point2.x);
Console.WriteLine(point2.y);
Console.WriteLine(point2.bulbul);

point2.x = 156;

Console.WriteLine();
Console.WriteLine(point1.x);
Console.WriteLine(point1.y);
Console.WriteLine(point1.bulbul);
Console.WriteLine();
Console.WriteLine(point2.x);
Console.WriteLine(point2.y);
Console.WriteLine(point2.bulbul);
struct Point
{
    // в структуре нельзя явно инициализировать переменные
    public int x;
    public int y;
    public bool bulbul;

    public Point(int x, int y, bool bulbul)
    {
        this.x = x;
        this.y = y;
        this.bulbul = bulbul;
    }
}

// структура не может наследоваться от другой структуры, наследование здесь невозможно 

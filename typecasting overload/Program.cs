using System.ComponentModel.DataAnnotations;

Rectangle rectangle = new Rectangle() { Width = 4, Height = 4 };
Square square = new Square { Length = 5 };
rectangle.Draw();
square.Draw();

Rectangle rectSquare = square;
rectSquare.Draw();

Square squareRect = (Square)rectangle;
squareRect.Draw();

int number = int.Parse(Console.ReadLine());
Square intSquare = number;
intSquare.Draw();

Console.WriteLine((int)intSquare);
abstract class Figure
{
    public abstract void Draw();
}

abstract class Quadranangle : Figure { }

class Rectangle : Quadranangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public static implicit operator Rectangle(Square s)
    {
        return new Rectangle 
        { 
            Height = s.Length, 
            Width = s.Length* 2
        };
    }

    public override void Draw()
    {
        for (int i = 0; i <Height ; i++, Console.WriteLine())
        {
            for (int j = 0; j < Width; j++)
            {
                Console.Write("* ");
            }
        }
        Console.WriteLine();
    }
}

class Square : Quadranangle
{
    public int Length { get; set; }

    public static explicit operator Square(Rectangle rectangle)
    {
        return new Square { Length = rectangle.Height };
    }
    public static explicit operator int(Square square)
    {
        return square.Length;
    }

    public static implicit operator Square(int number)
    {
        return new Square { Length = number }; 
    }
    public override void Draw()
    {
        for (int i = 0; i < Length; i++, Console.WriteLine())
        {
            for (int j = 0; j < Length; j++)
            {
                Console.Write("* ");
            }
        }
        Console.WriteLine();
    }
}


// нельзя неявно преобразовывать со старшего типа в младший с потерей данных, и вообще нельзя преобразовать на бул явно или неявно

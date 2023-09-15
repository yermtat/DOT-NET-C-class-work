// extension methods
// 

string rickroll = "never gonna give you up, never gonna let you down, never gonna lie around and desert you";
Console.WriteLine(rickroll.CountWords());  // как бы дополнение к уже существующему классу, т.е. мы вызываем метод от стринга

static class StringExtenshion
{
    public static int CountWords(this string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }

        return str.Split(' ').Length;
    }
}


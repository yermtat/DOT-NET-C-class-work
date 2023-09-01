Console.WriteLine(Summ(new int[] { 1, 6, 9, 4, 5, 45, 54, 5, 78, 4}));
SummParams(out int summ, 1, 6, 9, 4, 5, 45, 54, 5, 78, 4);
Console.WriteLine(summ);


int Summ(int[] ints)
{
    int summ = default;
    foreach (int i in ints)
    {
        summ += i;
    }
    return summ;

}

void SummParams(out int summ, params int[] ints) // парамс позволяет принимать бесконечное количество элементов, всегда указывается в параметрах последним
{
    summ = default;
    foreach (int i in ints)
    {
        summ += i;
    }

}
// ref out

int[] arr = new int[2] { 2, 2 };
int n1 = default, n2 = default/*, n3 = default*/; // присваивает дефолтное значение как фигурные скобки в плюсах
//Console.WriteLine($"arr = [{arr[0]}, {arr[1]}], n1 =  {n1}, n2 = {n2}, n3 = {n3}");
Foo(arr, n1, ref n2, out int n3); // ref работает просто как ссылка, должна быть инициализирована, out позволяет объявлять переменные прямо внутри вызова функции
Console.WriteLine($"arr = [{arr[0]}, {arr[1]}], n1 =  {n1}, n2 = {n2}, n3 = {n3}");

void Foo(int[] arr, int n1, ref int n2, out int n3)
{
    arr[0] = 5;
    arr[1] = 6;
    n1 = 6;
    n2 = 45;
    n3 = 666;  // аут параметр обязательно нужно инициализировать внутри функции
}

int b = default;
Int32.TryParse("17", out int a);
Int32.TryParse("15", out b);
Console.WriteLine($"{a}  {b}");

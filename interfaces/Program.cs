// интерфейс - инструмент похожий на класс, в основном содержащий методы без реализации. интерфейсы всегда паблик
// наследоваться можно только от одного класса, но реализовать интерфейсов можно сколько угодно
// в интерфейсе нельзя создать обычное поле, в абстрактном классе - можно.в интерфейсе можно создать статические поля, константные и проперти
// изначально в интерфейсах нельзя было создать метод с реализацией, но начиная с 8 версии можно


//interface IInterface
//{
//    void foo()
//    {

//    }
//}


using System.Reflection.Metadata;

FrontEndDeveloper frontEnd = new FrontEndDeveloper { Name = "John", Surname = "Doe" };
BackEndDeveloper backEnd = new BackEndDeveloper { Name = "Moye", Surname = "Imya" };
FullStackDeveloper fullStack = new FullStackDeveloper { Name = "Atilla", Surname = "Ismayil" };

BackEndAnnouncement(backEnd, new string[] { "C#", "Python", "C++" });
BackEndAnnouncement(fullStack, new string[] { "C#", "Python", "PHP" });
FrontEndAnnouncement(frontEnd);
FrontEndAnnouncement(fullStack);
FullStackAnnouncement(fullStack, new string[] { "C#", "Python", "C++" });




//void BackEndAnnouncement(BackEndDeveloper backEnd, string[] languages)
//{

//}

void BackEndAnnouncement(IBackEndDeveloper developer, string[] languages) // любой класс, реализующий этот интерфейс может войти в эту функцию
{
    developer.knowBackEndLanguage(languages);
}

void FrontEndAnnouncement(IFrontEndDeveloper frontEnd)
{
    frontEnd.KnowCSS();
    frontEnd.KnowHTML();
    frontEnd.KnowJS();
}

void FullStackAnnouncement(IFullStackDeveloper fullStackDeveloper, string[] languages)
{
    fullStackDeveloper.knowBackEndLanguage(languages);
    fullStackDeveloper.KnowCSS();
    fullStackDeveloper.KnowHTML();
    fullStackDeveloper.KnowJS();
}


class FrontEndDeveloper :Human, IFrontEndDeveloper
{
    public void KnowCSS()
    {
        Console.WriteLine("I know CSS");
    }

    public void KnowHTML()
    {
        Console.WriteLine("I know HTML");
    }

    public void KnowJS()
    {
        Console.WriteLine("I know JS");
    }
}


class BackEndDeveloper : Human, IBackEndDeveloper
{
    public void knowBackEndLanguage(string[] languages)
    {
        Console.WriteLine("I know: ");
        foreach (var language in languages)
        {
            Console.WriteLine ($"{language}");
        };
    }
}

class FullStackDeveloper : Human, IFullStackDeveloper
{
    public void knowBackEndLanguage(string[] languages)
    {
        Console.WriteLine("I know: ");
        foreach (var language in languages)
        {
            Console.WriteLine($"{language}");
        };
    }

    public void KnowCSS()
    {
        Console.WriteLine("I know CSS");
    }

    public void KnowHTML()
    {
        Console.WriteLine("I know HTML");
    }

    public void KnowJS()
    {
        Console.WriteLine("I know JS");
    }
}


interface IFrontEndDeveloper
{
    void KnowHTML();
    void KnowCSS();
    void KnowJS();

}

interface IBackEndDeveloper
{
    void knowBackEndLanguage(string[] language);
}

interface IFullStackDeveloper : IFrontEndDeveloper, IBackEndDeveloper
{

}
abstract class Human
{
    public string Name { get; set; }
    public string Surname { get; set; }
}
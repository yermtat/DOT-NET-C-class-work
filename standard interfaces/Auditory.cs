
using System.Collections;

class Auditory : IEnumerable
{
    Student[] students =
    {
        new Student
        {
            FirstName = "Ryan",
            LastName = "Gosling",
            BirthDay = new DateTime(1980, 11, 12),
            StudentCard = new StudentCard{Id = 111280, Series = "RG"}
        },
        new Student
        {
            FirstName = "Atilla",
            LastName = "Ismail",
            BirthDay = new DateTime(2008, 10, 7),
            StudentCard = new StudentCard{Id = 100708, Series = "AI"}
        },
        new Student
        {
            FirstName = "Napoleon",
            LastName = "Bonopart",
            BirthDay = new DateTime(1769, 08, 15),
            StudentCard = new StudentCard{Id = 150869, Series = "NB"}
        },
        new Student
        {
            FirstName = "Aelita",
            LastName = "MArsianskaya",
            BirthDay = new DateTime(3025, 12, 31),
            StudentCard = new StudentCard{Id = 311225, Series = "AM"}
        }
    };

    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }

    public IEnumerator GetEnumerator()
    {
        return students.GetEnumerator();
    }

    public void Sort(IComparer comparer)
    {
        Array.Sort(students, comparer);
    }

    public void Sort()
    {
        Array.Sort(students);
    }

}
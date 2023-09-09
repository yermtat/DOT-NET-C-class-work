Auditory auditory = new Auditory();

foreach (var student in auditory)
{
    Console.WriteLine(student);
}

//auditory.Sort(new DateComparer());
auditory.Sort();

Console.WriteLine();
foreach (var student in auditory)
{
    Console.WriteLine(student);
}

//Student student1 = new Student
//{
//    FirstName = "O'Ryan",
//    LastName = "O'Gosling",
//    BirthDay = new DateTime(1988, 1, 1),
//    StudentCard = new StudentCard { Id = 111288, Series = "OO" }
//};

//Student student2 = (Student)student1.Clone();
//Console.WriteLine(student2);

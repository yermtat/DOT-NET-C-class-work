using System.Runtime.CompilerServices;

List<Student> students = new()
{
    new Student{Name = "A", Surname = "B", BirthDay = new DateTime(2023, 9, 13)},
    new Student{Name = "Kalabna", Surname = "Embaby", BirthDay = new DateTime(2000, 9, 13)},
    new Student{Name = "Zambina", Surname = "Bambina", BirthDay = new DateTime(208, 9, 13)},
    new Student{Name = "Krinda", Surname = "Mashalata", BirthDay = new DateTime(1, 9, 13)},
    new Student{Name = "Atilla", Surname = "Ismayil", BirthDay = new DateTime(2020, 9, 13)},
    new Student{Name = "Gre", Surname = "Ta", BirthDay = new DateTime(2020, 9, 13)},
    new Student{Name = "Ma", Surname = "Laxov", BirthDay = new DateTime(1980, 9, 13)},
    new Student{Name = "Sa", Surname = "Laxav", BirthDay = new DateTime(1982, 9, 13)}

};


//Teacher teacher = new();

//foreach (Student student in students)
//{
//    teacher.examEvent += student.Exam;   // методы стьюдента "подписываются" на ивент. вызов ивента стриггерит вызов этих методов
//}

//teacher.Exam("Kak ya provel leto");

////teacher.examEvent.Invoke("kak ya provel leto");

//teacher.examEvent = null;
//teacher.examEvent.Invoke("kak ya provel leto");  // ивент так вызвать нельзя и на нулл он указывать не может, а тут появится ошибка при выполении



Teacher teacher1 = new() { Name = "Natiq" };
Teacher teacher2 = new() { Name = "Aleksey" };
Teacher teacher3 = new() { Name = "Nadir" };

teacher1.examEvent += students[4].Exam;
for (int i = 0; i < 4; i++)
{
    teacher2.examEvent += students[i].Exam;
}

for (int i = 5; i < students.Count; i++)
{
    teacher3.examEvent += students[i].Exam;
}

teacher1.Exam(new ExamEventArgs { Task = "c#" });
teacher2.Exam(new ExamEventArgs { Task = "c++"});
teacher3.Exam(new ExamEventArgs { Task = "Slazki" });  

class ExamEventArgs : EventArgs
{
    public string Task { get; set; }
}
class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDay { get; set; }

    //public void Exam(string task)
    //{
    //    Console.WriteLine($"{Name} {Surname} solved {task}");
    //}

    public void Exam(object sender, ExamEventArgs args)  // ивентАргс имеет информацию и о том кто отправляет запрос)
    {
        Console.WriteLine($" {((Teacher)sender).Name} send {args.Task}");
        Console.WriteLine($"{Name} {Surname} solved {args.Task}");
    }
}

class Teacher
{
    //public event ExamDelegate examEvent /*{ add { examEvent += value; } remove { } }*/ // методы которые под капотом а ля проперти

    //public void Exam(string task)
    //{
    //    examEvent(task);
    //}

    public EventHandler<ExamEventArgs> examEvent;

    public string Name { get; set; }

    public void Exam(ExamEventArgs task)
    { 
        examEvent(this, task);
    }
}

public delegate void ExamDelegate(string task);
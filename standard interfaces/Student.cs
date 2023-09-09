class Student : ICloneable, IComparable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDay { get; set; }
    public StudentCard StudentCard { get; set; }

    public object Clone() // deep copy
    {
        Student tmp = (Student)this.MemberwiseClone();   // shallow copy
        tmp.StudentCard = new StudentCard()
        {
            Series = this.StudentCard.Series,
            Id = this.StudentCard.Id
        };

        return tmp;
    }

    public int CompareTo(object? obj)
    {
        if (obj is Student student) 
        { 
            return FirstName.CompareTo(student.FirstName);
        }
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} - {StudentCard}";
    }
}

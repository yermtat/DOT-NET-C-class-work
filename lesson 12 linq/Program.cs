// LINQ - Language Integrated Query

// LINQ To Object
// LINQ To Dataset
// LINQ to SQL
// LINQ To Xml
// LIN to Entities
// PLINQ - Paralel LINQ

using System.Net.Cache;
using System.Net.Http.Headers;

int[] array = { 7, 9, 80, 12, 84, 52, 48, 0, 10, 21, 6, 5, 3, 19, 46, 6, 7, 8, -36, -987, -31};

IEnumerable<int> query = from i in array select i;
// линкью считается отложенным запросом. возвращает данные которые в реальном времени есть в массиве, поэтому если поменять какое-либо число в оригинальном массиве в линкью тоже поменяется
// т.к. это запрос через него нельзя поменять что-то в оригинальном массиве.
// его выполнение происходит только в тот момент когда мы от него требуем данные

#region LINQ
//foreach (var item in query)
//{
//    Console.Write($"{item} ");
//}

//Console.WriteLine();

//array[5] = 1244244;

//foreach (var item in query)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();
#endregion


//// where
//query = from i in array
//        where i < 0
//        select i;


//// orderby ascending descending
//query = from i in array
//        where i < 0
//        orderby i descending
//        select i;


//// group
//var group = from i in array
//            where i > 0
//            group i by i % 2;


//foreach (var item in group)
//{
//    if (item.Key == 0)
//    {
//        Console.WriteLine("Even numbers: ");
//    }
//    else { Console.WriteLine("Odd numbers: "); }

//    Console.WriteLine(item.Key);
//    foreach (var i in item)
//    {
//        Console.WriteLine($"    {i}");
//    }
//}
//Console.WriteLine();



//// into
//var query1 = from i in array
//             where i > 0
//             group i by i % 2 into result
//             from j in result
//             where j % 3 == 0
//             group j by j % 2;


//foreach (var item in query1)
//{

//    Console.WriteLine(item.Key);
//    foreach (var i in item)
//    {
//        Console.WriteLine($"    {i}");
//    }
//}




List<Country> countries = new()
{
    new Country() {Id = 1, Name = "USA", Capital = "Washington" },
    new Country() {Id = 2, Name = "Azerbaijan", Capital = "Baku" },
    new Country() {Id = 3, Name = "Germany", Capital = "Berlin" },
    new Country() {Id = 4, Name = "Ireland", Capital = "Dublin" },
    new Country() {Id = 5, Name = "Sweden", Capital = "Stockholm" },
    new Country() {Id = 6, Name = "Wales", Capital = "Cardiff" },
    new Country() {Id = 7, Name = "Neverlend", Capital = "Never"}
};

List<Employee> employees = new()
{
    new Employee() {Id = 1, Name = "Atilla", Age = 12, CountryId = 4},    
    new Employee() {Id = 2, Name = "Teymur", Age = 16, CountryId = 5},
    new Employee() {Id = 3, Name = "Nadir", Age = 42, CountryId = 7},
    new Employee() {Id = 4, Name = "Tatyana", Age = 24, CountryId = 6},
    new Employee() {Id = 5, Name = "Allita", Age = 12, CountryId= 2},
    new Employee() {Id = 6, Name = "Klavdiya", Age = 123, CountryId = 6},
    new Employee() {Id = 7, Name = "Ayxan", Age = 112, CountryId= 6},
    new Employee() {Id = 8, Name = "Atilla", Age = 11, CountryId = 2},
    new Employee() {Id = 9, Name = "Asu", Age = 31, CountryId = 3},
    new Employee() {Id = 10, Name = "Adol", Age = 31, CountryId= 3},
    new Employee() {Id = 11, Name = "Geri", Age = 36, CountryId = 3},
    new Employee() {Id = 12, Name = "Atilla", Age = 14, CountryId = 2},
};


//// join

//var result = from c in countries
//             join e in employees on c.Id equals e.CountryId
//             orderby e.Name ascending
//             select new { Name = e.Name, Country = c.Name };

//foreach (var em in result)
//{
//    //Console.WriteLine(em);
//    //Console.WriteLine(countries.First(c => c.Id == em.CountryId));

//    Console.WriteLine($"{em.Name} - {em.Country}");
//}




//// LINQ methods
//// LINQ First, FirstOrDefault

//var emp = employees.First(e => e.Id == 10);
//Console.WriteLine(emp);


//var emp1 = employees.FirstOrDefault(x => x.Id == 13);

//if (emp1 is not null)
//{
//    Console.WriteLine(emp1);
//}
//else
//{
//    Console.WriteLine("Not Found");
//}


//// Single, SingleOrDefault

//var emp = employees.Single(e => e.Name == "Allita");
//Console.WriteLine(emp);

//var emp1 = employees.SingleOrDefault(e => e.Name == "nya");
//if (emp1 != null) Console.WriteLine(emp1);
//else Console.WriteLine("Not Found");



//// Contains
//Employee employee = new Employee() { Id = 12, Name = "Atilla", Age = 14, CountryId = 2 };

//var a = employees.Contains(employee);
//a = employees.Contains(employees[11]);
//Console.WriteLine(a);


//// Where
//var emp = employees.Where(x => x.Name == "Atilla").ToList();
//emp.ForEach(Console.WriteLine);


//// Max Min
//var result = employees.Max(e => e.Age);
//Console.WriteLine(result);

//var emp = employees.FirstOrDefault(e => e.Age == employees.Max(x => x.Age));
//Console.WriteLine(emp);


////Average, Sum 
//var sumAge = employees.Sum(x => x.Age);
//Console.WriteLine(sumAge);
//var aver = employees.Average(x => x.Age);
//Console.WriteLine(aver);


//// OrderBy

//var empA = employees.OrderBy(e => e.Age).ToList();
//empA.ForEach(Console.WriteLine);
//Console.WriteLine();
//var empD = employees.OrderByDescending(e => e.Age).ToList();
//empD.ForEach(Console.WriteLine);
//Console.WriteLine();
//var empThen = employees.OrderBy(e => e.Name).ThenByDescending(e => e.Age).ToList();
//empThen.ForEach(Console.WriteLine);


//// Take, Skip
//var emp = employees.Take(2).ToList();
//emp.ForEach(Console.WriteLine);

//var emp1 = employees.TakeWhile(x => x.Age < 112).ToList();
//emp1.ForEach(Console.WriteLine);

//var emp2 = employees.Skip(2).Take(4).ToList();
//emp2.ForEach(Console.WriteLine);


//// All, Any
//var check = employees.All(e => e.Age > 20);
//Console.WriteLine(check);

//var check2 = employees.Any(e => e.Age == 11);

internal class Country
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Capital { get; set; }

    public override string ToString()
    {
        return $"Name: {Name} Capital: {Capital}";
    }
}

internal class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int CountryId { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Age}";
    }

}



//foreach (var item in query)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();
// Список студентов
using Task14_2_3.Classes;

var students = new List<Student>
{
   new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
   new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
   new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }}
};

// Список курсов
var coarses = new List<Coarse>
{
   new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
   new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
};

var CoarseForStudentWithEnglish = from student in students
                                  
                                  where student.Age < 29
                                    where student.Languages.Contains("английский")

                                  from coarse in coarses
                                    where coarse.Name == "Язык программирования C#"
                                  let yearOfBirth = DateTime.Now.Year - student.Age
                                  
                                  select new
                                  {
                                      Name = student.Name,
                                      YearOfBirth = yearOfBirth,
                                      coarseName = coarse.Name
                                  };

foreach (var student in CoarseForStudentWithEnglish)
{
    Console.WriteLine(student.Name + " " + student.YearOfBirth + " " + student.coarseName);
}
 

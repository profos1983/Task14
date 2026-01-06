using Task14_2_3.Classes;

// Наш список студентов
List<Student> students = new List<Student>
{
   new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
   new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
   new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
   new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
};

//Выберите всех студентов моложе 27, сгенерируйте из них анкеты (модель класса расположена ниже).

var studentByYear = from student in students
                    let yearOfBirth = DateTime.Now.Year - student.Age
                    where student.Age <= 27
                    select new Application
                    {
                        Name = student.Name,
                        YearOfBirth = yearOfBirth
                    };

foreach (var student in studentByYear)
{
    Console.WriteLine(student.Name + " " + student.YearOfBirth);
}
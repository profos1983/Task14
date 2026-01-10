using System.Security.Cryptography;
using Task15_4_1.Classes;

var departments = new List<Department>()
   {
       new Department() {Id = 1, Name = "Программирование"},
       new Department() {Id = 2, Name = "Продажи"}
   };

var employees = new List<Employee>()
   {
       new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
       new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
       new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
       new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
   };


//Задание 15.4.2
//Теперь сгруппируйте сотрудников по отделам, выведя на экран последовательно 
//сначала название отдела, а затем список его сотрудников

var result = from dep in departments
             join emp in employees on dep.Id equals emp.DepartmentId into employeeByDepatment
             select new
             {
                 Name = dep.Name,
                 listOfEmployees = employeeByDepatment.ToList()
             };

foreach (var dep in result)
{
    Console.WriteLine(dep.Name);
    foreach (var employee in dep.listOfEmployees)
    {
        Console.WriteLine(employee.Name);
    }
}


//  объявляем две коллекции
var letters = new string[] { "A", "B", "C", "D", "E" };
var numbers = new int[] { 1, 2, 3 };

var result2 = from lt in letters
              zip
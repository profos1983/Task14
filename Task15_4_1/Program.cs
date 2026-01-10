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

var result = from employee in employees
             join d in departments on employee.DepartmentId equals d.Id
             select new
             {
                 //EmployeeId = employee.DepartmentId,
                 Name = employee.Name,
                 Id = employee.Id,
                 DepartmentName = d.Name
             };

foreach (var employee in result)
{
    Console.WriteLine(employee.Name + " " + employee.Id + " " +  employee.DepartmentName);
}
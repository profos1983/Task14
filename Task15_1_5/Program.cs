//Задание 15.1.5
//Напишите недостающий код так, чтобы на выходе мы получили список всех IT-компаний без повторений.

var softwareManufacturers = new List<string>()
{
   "Microsoft", "Apple", "Oracle"
};

var hardwareManufacturers = new List<string>()
{
   "Apple", "Samsung", "Intel"
};

var itCompanies = softwareManufacturers.Union(hardwareManufacturers);

foreach (var company in itCompanies)
{
    Console.WriteLine(company);
}

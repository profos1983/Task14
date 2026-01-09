// Список моделей
using Task15_3_101.Classes;

var cars = new List<Car>()
{
   new Car() { Model  = "SX4", Manufacturer = "Suzuki"},
   new Car() { Model  = "Grand Vitara", Manufacturer = "Suzuki"},
   new Car() { Model  = "Jimny", Manufacturer = "Suzuki"},
   new Car() { Model  = "Land Cruiser Prado", Manufacturer = "Toyota"},
   new Car() { Model  = "Camry", Manufacturer = "Toyota"},
   new Car() { Model  = "Polo", Manufacturer = "Volkswagen"},
   new Car() { Model  = "Passat", Manufacturer = "Volkswagen"},
};

// Список автопроизводителей
var manufacturers = new List<Manufacturer>()
{
   new Manufacturer() { Country = "Japan", Name = "Suzuki" },
   new Manufacturer() { Country = "Japan", Name = "Toyota" },
   new Manufacturer() { Country = "Germany", Name = "Volkswagen" },
};

var result = from car in cars //выбирем машины
             join m in manufacturers on car.Manufacturer equals m.Name // соединим по общему ключу (имя производителя) с производителем
             select new // Спроецирум выборку в новую анонимную сущность
             {
                 Name = car.Model,
                 Manufacturer = m.Name,
                 Country = m.Country
             };

// выведем результаты
foreach (var item in result)
    Console.WriteLine($"{item.Name} - {item.Manufacturer} ({item.Country})");
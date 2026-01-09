using Task15_3_100.Classes;

var cars = new List<Car>()
{
   new Car("Suzuki", "JP"),
   new Car("Toyota", "JP"),
   new Car("Opel", "DE"),
   new Car("Kamaz", "RUS"),
   new Car("Lada", "RUS"),
   new Car("Honda", "JP"),
};

// Группировка по стране - производителю
var carsByCountry = from car in cars
                    group car by car.CountryCode;


var carsByCountry2 = cars
   .GroupBy(car => car.CountryCode) // группируем по стране-производителю
   .Select(group => new
   { //  создаем новую сущность анонимного типа
       Name = group.Key,
       Amount = group.Count()
   });

Console.WriteLine();


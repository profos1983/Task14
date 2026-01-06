var cars = new[] { "Volvo", "Opel", "Suzuki", "Toyota", "Lada", "Kamaz" };

// пропустим первые два элемента
var skip2 =cars.Skip(2);

foreach (var car in skip2)
    Console.WriteLine(car);
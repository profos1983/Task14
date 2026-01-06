using Task14_1_1.Classes;

// Добавим Россию с её городами
var russianCities = new List<City>();
    russianCities.Add(new City("Москва", 11900000));
    russianCities.Add(new City("Санкт-Петербург", 4991000));
    russianCities.Add(new City("Волгоград", 1099000));
    russianCities.Add(new City("Казань", 1169000));
    russianCities.Add(new City("Севастополь", 449138));

//А теперь попробуйте выбрать все города, название у которых не длиннее 10 букв, и отсортируйте их по длине названия.

var city2 = from c in russianCities
            where c.Name.Length <= 10
            orderby c.Name.Length descending
            select c;

foreach (var city in city2)
{
    Console.WriteLine(city.Name);
}


// Создадим модель класс для города

var Countries = new Dictionary<string, List<City>>();

// Добавим Россию с ее городами
Countries.Add("Россия", russianCities);

// Добавим Беларусь
var belarusCities = new List<City>();
belarusCities.Add(new City("Минск", 1200000));
belarusCities.Add(new City("Витебск", 362466));
belarusCities.Add(new City("Гродно", 368710));
Countries.Add("Беларусь", belarusCities);

// Добавим США
var americanCities = new List<City>();
americanCities.Add(new City("Нью-Йорк", 8399000));
americanCities.Add(new City("Вашингтон", 705749));
americanCities.Add(new City("Альбукерке", 560218));
Countries.Add("США", americanCities);

var millionCites = from country in Countries
                    from city in country.Value
                    where city.Population >= 1000000
                    orderby city.Population descending
                    select city;

foreach (var city in millionCites)
{
    Console.WriteLine($"{city.Name} - {city.Population}");
}

//Напишите метод, возвращающий среднее арифметическое числовых объектов коллекции.
//Шаблон метода дан ниже:

int[] array = new int[5] {1, 2, 3, 4, 7 };

double av = Average(array);

Console.WriteLine(av);


static double Average(int[] numbers)
{
    double result = Convert.ToDouble (numbers.Sum()) / numbers.Count(); 
    return result;
}



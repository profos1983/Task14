//Факториал натурального числа n — это произведение всех натуральных целых чисел 
//от 1 до n включительно
//Шаблон функции факториала дан ниже:
//Допишите функцию, используя знания LINQ, полученные в этом юните.


long u1 = Factorial(5);
Console.WriteLine(u1);


static long Factorial(int number)
{
    int[] charArray = new int[number];

    for (int i = 0; i < number; i++)
    {
        charArray[i] = i + 1;
    }

    long result = charArray.Aggregate((x, y)  => x * y);
    return result;
}


//Задание 15.2.8
//Напишите программу с бесконечным циклом, как в предыдущем юните, которая будет
//ожидать ввода числа с клавиатуры (используйте Console.ReadLine());
//добавлять число в список, хранящийся в памяти;
//выводить после добавления следующую информацию: количество чисел в списке, сумму
//всех чисел списка, наибольшее и наименьшее числа, а также их среднее значение.

List<int> listOfNumber = new List<int> ();

while (true)
{
    Console.WriteLine();

    // Предлагаем Пользователю ввести число
    Console.WriteLine("Введите число, для добавление в массив чисел, либо введите слово Exit для выхода: ");

    // Считываем данные, введенные пользователем в переменную типа string
    string dateFromUser = Console.ReadLine();

    // Проверяем, чтобы пользователь не ввел пустое значение.
    if (string.IsNullOrEmpty(dateFromUser))
    {
        Console.WriteLine("Необходимо ввести число.");
    }

    // Проверяем, ввел ли Пользователь слово Exit
    if (dateFromUser == "Exit")
    {
        break;
    }

    // Переводим строку в число и записываем в массив
    try
    {
        int userNumber = Convert.ToInt32(dateFromUser);
        listOfNumber.Add(userNumber);
        Console.Clear();
        // Выводим данные после ввода числа
        Console.WriteLine("Текущее количество чисел в списке: " + listOfNumber.Count);
        Console.WriteLine("Сумма всех чисел в списке: " + listOfNumber.Sum());
        Console.WriteLine("Наибольшее число в списке: " + listOfNumber.Max());
        Console.WriteLine("Наименьшее число в списке: " + listOfNumber.Min());
        Console.WriteLine("Среднее значение всех чисел в списке: " + listOfNumber.Average());
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }


}


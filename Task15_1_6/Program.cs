//Задание 15.1.6
//Напишите программу, которая будет принимать на вход строку текста с консоли 
//(конструкция Console.Readline()) и выводить в ответ список содержащихся в 
//строке уникальных символов без пробелов и следующих знаков препинания: , . ; :  ? !.

Console.WriteLine("Введите строку текста.");

string userString = Console.ReadLine();

string punctuacianChar = ",.;:?!";

var result = userString.Except(punctuacianChar);

foreach (var item in result)
{
    Console.Write(item);
}
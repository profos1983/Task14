using System.Numerics;
using System.Text.RegularExpressions;
using Task15_3_3.Classes;

var phoneBook = new List<Contact>();

// добавляем контакты
phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));


//Некоторые из них имеют реальный email-адрес, а некоторые — фейковый (те, которые в домене example)
//Нам нужно разбить их на две группы: фейковые и реальные, и вывести результат в консоль
//Решите эту задачу с помощью группировки.

var groupPhoneBook = from phone in phoneBook
                     let emailStatus = phone.Email.Contains("example")
                     group phone by emailStatus;

var groupPhoneBook2 = phoneBook.GroupBy(s => s.Email.Contains("example"));

foreach (var phone in groupPhoneBook)
{
    Console.WriteLine("Адрес является фейковым: " + phone.Key);
    foreach(var adress in phone)
    {
        Console.WriteLine(adress.Email);
    }
}
                     

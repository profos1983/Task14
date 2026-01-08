using Task14_2_5.Classes;

var contacts = new List<Contact>()
{
   new Contact() { Name = "Андрей", Phone = 79994500508 },
   new Contact() { Name = "Сергей", Phone = 799990455 },
   new Contact() { Name = "Иван", Phone =   79999675334 },
   new Contact() { Name = "Игорь", Phone =  8884994 },
   new Contact() { Name = "Анна", Phone =   665565656 },
   new Contact() { Name = "Василий", Phone = 3434 }
};

//Посчитайте, у скольких из них неверные номера телефонов 
//(верный телефон содержит 11 цифр и начинается с семёрки).


var rightNumber = contacts.Count(c => c.Phone.ToString().Length != 11 || !c.Phone.ToString().StartsWith('7') );

Console.WriteLine("Список контактов содержит " + rightNumber + " неправильных номера.");
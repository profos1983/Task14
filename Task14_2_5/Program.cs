using Task14_2_5.Classes;

var contacts = new List<Contact>()
{
   new Contact() { Name = "Андрей", Phone = 799995005 },
   new Contact() { Name = "Сергей", Phone = 799990455 },
   new Contact() { Name = "Иван", Phone = 79999675 },
   new Contact() { Name = "Игорь", Phone = 8884994 },
   new Contact() { Name = "Анна", Phone = 665565656 },
   new Contact() { Name = "Василий", Phone = 3434 }
};

//Сделайте вывод контактов в консоль по два в бесконечном цикле.
//Выводить нужно постранично, например так: вы ввели 1 — показало Андрея и Сергея, 
//2 — Ивана и Игоря, 3 — Анну и Василия.

Console.WriteLine("Для прокрутки списка контактов, введие целое число, начиная с 1, либо введите Exit, для выхода: ");
while (true)
{
    try
    {
        string checkForExit = Console.ReadLine();
        if (checkForExit == "Exit")
        {
            break; 
        }
        
        int numberChose = Convert.ToInt32(checkForExit);
        
        if (numberChose >  0 && numberChose <= contacts.Count / 2 )
        {
            var partOfContact = contacts.Skip( numberChose * 2 - 2).Take(2);
            
            foreach(Contact contact in partOfContact)
            {
                Console.WriteLine("Имя: " + contact.Name + ", Телефон: " + contact.Phone);
            }
        }
        else
        {
            Console.WriteLine("Введенное число, больше чем пар записей в списке контактов");
        }
    }
    catch(Exception e) 
    {
        Console.WriteLine(e.Message);
    }
}
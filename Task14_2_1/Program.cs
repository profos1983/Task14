string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

//Сделайте выборку в анонимный тип с одновременной сортировкой слов по длине. Результат выведите в консоль.

var sortWords = from word in words
                orderby word.Length
                select new
                {
                    Name = word,
                    Lenght = word.Length
                };
                



foreach(var word in sortWords)
{
    Console.WriteLine(word.Name + " " + word.Lenght);
}

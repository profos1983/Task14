
//Соедините все слова в одну последовательность (каждое слово — отдельный элемент последовательности).

string[] text = { "Раз два три", "четыре пять шесть", "семь восемь девять" };

var result = from str in text 
             from word in str.Split(' ')
             select word;

foreach (var word in result)
{
    Console.WriteLine(word);
}

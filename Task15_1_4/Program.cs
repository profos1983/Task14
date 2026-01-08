//Напишите метод для поиска общих букв в двух словах.

string word1 = "Яблоко";
string word2 = "Яблоня";

char[] word1ByChar  = word1.ToCharArray();
char[] word2ByChar  = word2.ToCharArray();

var intersecChar = word1ByChar.Intersect(word2ByChar);

var intersecChar2 = word1.Intersect(word2);

foreach (char c in intersecChar)
{
    Console.Write(c);
}
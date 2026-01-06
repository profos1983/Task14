var numsList = new List<int[]>()
{
   new[] {2, 3, 7, 1},
   new[] {45, 17, 88, 0},
   new[] {23, 32, 44, -6},
};

//Сделайте выборку всех чисел в новую коллекцию, расположив их в ней по возрастанию.

var sortList = from array in numsList
               from num in array
               orderby num
               select num;






foreach (var num in sortList)
{
    Console.WriteLine(num);
}
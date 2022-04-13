// See https://aka.ms/new-console-template for more information
using MyList;

MyList<int> list = new MyList<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine();

list.Add(1);
foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine();

list.Remove(3);
foreach (var item in list)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine(list[3]);
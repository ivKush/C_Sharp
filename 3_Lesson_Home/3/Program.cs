// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число: ");
var empty = Console.ReadLine();
int N = empty == null ? 0 : int.Parse(empty);
int i=1;
while (N>=i)
{
var a = Math.Pow(i, 3);
System.Console.Write($"{a} ");
i++;
}

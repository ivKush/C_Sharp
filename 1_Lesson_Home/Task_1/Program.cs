//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

    //a = 5; b = 7 -> max = 7
    //a = 2 b = 10 -> max = 10
    //a = -9 b = -3 -> max = -3

Console.WriteLine("Введите 1 число: ");
var c = Console.ReadLine();

Console.WriteLine("Введите 2 число: ");
var d = Console.ReadLine();

int a = int.Parse(c);
int b = int.Parse(d);
int max = 0;

if (a>b)  
    {
    max=a;
    }
else max=b;

System.Console.Write("Максимальное число: ");
Console.Write(max);

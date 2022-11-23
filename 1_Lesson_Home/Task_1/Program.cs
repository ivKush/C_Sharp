//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

    //a = 5; b = 7 -> max = 7
    //a = 2 b = 10 -> max = 10
    //a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа и узнайте, какое из них наибольшее: ");
var number1 = Console.ReadLine();
var number2 = Console.ReadLine();

int a = int.Parse(number1);
int b = int.Parse(number2);
int max = 0;

if (a>b)  
    {
    max=a;
    }
else max=b;

System.Console.Write("Максимальное число: ");
Console.Write(max);

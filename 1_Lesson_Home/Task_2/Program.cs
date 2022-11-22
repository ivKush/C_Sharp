//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите три числа и узнайте, какое из них максимальное: ");

var number1 = Console.ReadLine();
var number2 = Console.ReadLine();
var number3 = Console.ReadLine();

int a = int.Parse(number1);
int b = int.Parse(number2);
int c = int.Parse(number3);
int max = 0;

if (a>=b)  
    {
    max=a;
    }
else max=b;


if (c>=max)
    {
    max=c;
    }
else max=max;

System.Console.Write("Максимальное число: ");
Console.Write(max);

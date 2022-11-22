// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число и узнайте четное ли оно: ");
var number1 = Console.ReadLine();
int a = int.Parse(number1);
int b=a%2;
if (b==0) System.Console.WriteLine("чётное");

else System.Console.WriteLine("не чётное");


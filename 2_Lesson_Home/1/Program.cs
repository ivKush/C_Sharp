// Задача 1:Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int a; 
System.Console.WriteLine(a = new Random().Next(1000));

double b = a / 10; 
double c = b % 10;

System.Console.WriteLine(c);
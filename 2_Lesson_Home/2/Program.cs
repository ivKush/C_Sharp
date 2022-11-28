// Задача 2:Напишите программу, которая выводит случайное
//  трёхзначное число и удаляет вторую цифру этого числа.

int a; 
System.Console.WriteLine(a = new Random().Next(100,1000));

int b = a / 100; 
double c = a % 10;

System.Console.WriteLine( $"{b}{c}");

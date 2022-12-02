//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//  452 -> 11
//  82 -> 10
//  9012 -> 12

int A = int.Parse(Console.ReadLine());

int c = 0;
for (int i = 0, b; i < A; b = A % 10, A = A / 10, c = b + c) ;
System.Console.WriteLine(c);

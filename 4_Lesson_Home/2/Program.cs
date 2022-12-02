//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//  452 -> 11
//  82 -> 10
//  9012 -> 12

int A = int.Parse(Console.ReadLine());

int summ = 0;
for (int i = 0, num; i < A; num = A % 10, A = A / 10, summ = num + summ) ;
System.Console.WriteLine(summ);

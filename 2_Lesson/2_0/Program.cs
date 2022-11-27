//   Напишите программу, которая выводит случайное
//    трехзначное число и на выходе показывает
//     последнюю цифру этого числа.

int Num(int num)

{
return num %10;
}
System.Console.WriteLine(Num(new Random().Next(100,1000)));

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

System.Console.Write("Ввведите пятизначное число: ");
var empty = Console.ReadLine();
int number = empty == null ? 0 : int.Parse(empty);
string a;
if (number % 10 == number / 10000 && (number / 10) % 10 == (number / 1000) % 10) a = "ДА"; else a = "НЕТ";
if (number > 99999 || number < 10000) a = "Error";
if (number < 0) a = "НЕТ";
System.Console.WriteLine(a);


// System.Console.Write("Ввведите пятизначное число: ");
// int number = int.Parse(Console.ReadLine());
// string a;
// if (number % 10 == number / 10000 && (number / 10) % 10 == (number / 1000) % 10)
// {
//     a = "ДА";
// }
// else a = "НЕТ";
// if (number > 99999 || number < 10000)
// {
//     a = "Error";
// }
// System.Console.WriteLine(a);
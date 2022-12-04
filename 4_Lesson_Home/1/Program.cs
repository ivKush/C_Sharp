//  Напишите цикл, который принимает на вход два числа (A и B) и 
//  возводит число A в натуральную степень B. 
//  Без модуля Math, используем цикл for.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = A;
for (int i = 1; i < B; C = C * A, i++);
System.Console.Write(C);


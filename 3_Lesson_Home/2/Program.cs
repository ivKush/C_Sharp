// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Введите aX:");
int ax = int.Parse(Console.ReadLine());
Console.Write("Введите aY:");
int ay = int.Parse(Console.ReadLine());
Console.Write("Введите aZ:");
int az = int.Parse(Console.ReadLine());
Console.Write("Введите bX:");
int bx = int.Parse(Console.ReadLine());
Console.Write("Введите bY:");
int by = int.Parse(Console.ReadLine());
Console.Write("Введите bZ:");
int bz = int.Parse(Console.ReadLine());

   double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
 
Console.WriteLine(result);
//Console.WriteLine(Math.Round(Distance(ax, ay, az, bx, by, bz), 2));

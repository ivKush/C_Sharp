// Задача 1: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void PosiNums(string num)
{
    int i = 0;
    //string a = num;
    for ( ; num != ""; num = Console.ReadLine())
    {
        int n = int.Parse(num);
        if (n > 0) i++;
    }
    Console.WriteLine(i);
}
string n = Console.ReadLine();
PosiNums(n);

// void PosiNums(string num)
// {
//     int i = 0;
//     string a = num;
//     for (int n = 0; a != ""; a = Console.ReadLine())
//     {
//         n = int.Parse(a);
//         if (n > 0) i++;
//     }
//     Console.WriteLine(i);
// }
// string n = Console.ReadLine();
// PosiNums(n);


// int CountNum()
// {
//     int count = 0;
//     string world;
//     while (true)
//     {
//         Console.WriteLine("Output any number: ");
//         world = Console.ReadLine();

//         if (world == "") return count;
//         else if (int.Parse(world) > 0) count += 1;
//     }
// }
// Console.Write(CountNum());

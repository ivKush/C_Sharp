//   Напишите программу, которая задаёт массив из 8 элементов 
//   случайными числами и выводит их на экран. Оформите заполнение массива и 
//   вывод в виде функции (пригодится в следующих задачах).

int nums = int.Parse(Console.ReadLine());
int i = 0;
for (int n = 0; n < nums; nums = nums / 10, i++);
 //   System.Console.Write(i);
int[] Mass = new int [i];
int s = 1;
for (int z = 0 ; z < nums; Mass[Mass.Length - s] = nums % 10, nums = nums / 10, s++)
{
System.Console.Write($"{Mass[s]} ");
}

// int nums = int.Parse(Console.ReadLine());
// int res = Metod4(nums);
// Console.WriteLine(res);
// string nums = Console.ReadLine();
//     void OutMass(string nums)
//     {
//         // int[] numbers = new int[nums.Length];
//         //int temp;
//         for (int i = 0; i < nums.Length; i++)
//             System.Console.Write();
//     }

// OutMass();
//     {
//         if (Int32.TryParse(args[i],out temp))
//         {
//             numbers[i] = temp;
//         }
//         else
//         {
//             numbers[i] = 0;
//         }
//      }
//    }
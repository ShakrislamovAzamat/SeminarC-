// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int SecondDigit(int num)
// {
//     return num = (num / 10) % 10;
// }

// Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num} -> {SecondDigit(num)}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

// int ThirdDigit(int x)
// {
//     while (x > 999)
//         {
//             x = x / 10;
//         }
//     return x = x % 10;
// }

// bool Prov(int x)
// {
//     if (x<100)
//     {
//         Console.WriteLine($"{x} -> Третьей цифры нет");
//         return false;
//     }
//     return true;
// }

// Console.Write("Input Number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (Prov(num))
// {
//     Console.WriteLine($"{num} -> {ThirdDigit(num)}");
// }


// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// bool Weekend( int num)
// {
//     if (num == 6 || num == 7)
//     {
//         return true;
//     }
//     else return false;
// }

// Console.Write("Input number from 1 to 7: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if (Weekend(day))
// {
//     Console.WriteLine($"{day} -> ДА");
// }
// else Console.WriteLine($"{day} -> НЕТ");

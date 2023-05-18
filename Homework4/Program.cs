// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int Exponent(int a, int b)
// {
//     int exp = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         exp = exp * a;
//     }
//     return exp;
// }


// Console.Write("Input number A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number B: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{numA}, {numB} -> {Exponent(numA, numB)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int SumDigits(int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         sum = sum + (num % 10);
//         num = num / 10;
//     }
//     return sum;
// }

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num} -> {SumDigits(num)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//         //Console.Write(newArray[i] + " ");
//     }
//     //Console.WriteLine();
//     return newArray;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Write("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minValue ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maxValue ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
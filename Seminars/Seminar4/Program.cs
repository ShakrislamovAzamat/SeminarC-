//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int DigitCount(int num)
// {
//     int count = 0;
//     while (num > 0)
//     {
//         count++;
//         num/=10; // num = num / 10
//     }
//     return count;
// }

// Console.WriteLine("Input number ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Number of digits in {num} -> {DigitCount(num)}");


//Задача 4. Напишите программу, которая выводит массив из n элементов,
// заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

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



//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120

// Console.WriteLine("Input N ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 1; i <= num; i++)
// {
//     result = result*i;
// }
// Console.WriteLine($"{num} -> {result}");


//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// Console.WriteLine("Input N ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= num; i++)
// {
//     sum = sum+i;
// }
// Console.WriteLine($"{num} -> {sum}");
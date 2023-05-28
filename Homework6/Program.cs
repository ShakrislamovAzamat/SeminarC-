// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int NumPosElements(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     return count;
// }

// int[] MyArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         System.Console.Write($"input {i} element: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.Write("input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = MyArray(size);
// PrintArray(myArray);
// System.Console.Write(NumPosElements(myArray));



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// System.Console.WriteLine("Input coefficients of line 1: ");
// System.Console.Write($"k1 = ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write($"b1 = ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Input coefficients of line 2: ");
// System.Console.Write($"k2 = ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write($"b2 = ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// double[] coords = new double[2];
// int coordX = 0;
// int coordY = 1;
// coords[coordX] = (b2 - b1) / (k1 - k2);
// coords[coordY] = k1 * coords[coordX] + b1;

// System.Console.Write($"Crosspoint of lines ({coords[coordX]}; {coords[coordY]})");


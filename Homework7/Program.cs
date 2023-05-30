//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5   7   -2  -0,2
//  1  -3,3   8  -9,9
//  8   7,8 -7,1   9


// double[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = Math.Round(new Random().Next(minValue, maxValue)
//             +new Random().NextDouble(), 2);
//         }
//     }
//     return array;
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j]+"   ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Input rows (M): ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input columns (N): ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] newArray = Create2DRandomArray(rows, columns, minValue, maxValue);
// Print2DArray(newArray);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void FindIndexNum(int rowPos, int colPos, int[,] array)
// {
//     if (rowPos < array.GetLength(0) && colPos < array.GetLength(1))
//     {
//         System.Console.WriteLine(array[rowPos, colPos]);
//     }
//     else System.Console.WriteLine($"Элемента с индексом [{rowPos}, {colPos}] в массиве нет!");
// }

// Console.Write("Input rows to create array: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input columns to create array: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(newArray);

// Console.Write("Input rowPos to find: ");
// int rowPos = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input colPos to find: ");
// int colPos = Convert.ToInt32(Console.ReadLine());

// FindIndexNum(rowPos, colPos, newArray);



// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void PrintAverageNumbers(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + "; ");
//     }
//     Console.WriteLine();

// }

// double[] AverageOfColumnNum(int[,] array)
// {
//     double[] average = new double[array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         double sum = 0;
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             sum = sum + array[j, i];
//         }
//         average[i] = sum / (array.GetLength(0));
//     }
//     return average;
// }

// Console.Write("Input rows to create array: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input columns to create array: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myNewArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myNewArray);
// double[] averageArray = AverageOfColumnNum(myNewArray);
// Console.Write("Среднее арифметическое каждого столбца: ");
// PrintAverageNumbers(averageArray);
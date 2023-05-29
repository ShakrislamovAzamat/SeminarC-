// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
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
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input minValue ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input maxValue ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Print2DArray(Create2DRandomArray(rows, columns, minValue, maxValue));


//Задача 4. задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
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

// int SumOfMainDiag(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j) sum += array[i, j];
//         }
//     }
//     Console.WriteLine();
//     return sum;
// }

// Console.Write("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input minValue ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input maxValue ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine(SumOfMainDiag(myArray));


// Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
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

// int[,] Quad(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
//         }
//     }
//     return array;
// }

// Console.Write("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input minValue ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input maxValue ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine();
// myArray = Quad(myArray);
// Print2DArray(myArray);


//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве
// находится по формуле: Aₘₙ = m+n.

// int[,] Create2DArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = i + j;
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

// Console.Write("Input number of rows (M): ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input number of columns (N): ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns);
// Print2DArray(myArray);
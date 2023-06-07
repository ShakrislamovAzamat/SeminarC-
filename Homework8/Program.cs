// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
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
//             System.Console.Write(array[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] SortRows(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             int maxInRow = j;
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, k] > array[i, j])
//                 {
//                     maxInRow = k;
//                     int temp = array[i, maxInRow];
//                     array[i, maxInRow] = array[i, j];
//                     array[i, j] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// System.Console.Write("Input rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = CreateRandom2DArray(rows, columns, minValue, maxValue);
// Print2DArray(newArray);
// int[,] sortArray = SortRows(newArray);
// Print2DArray(sortArray);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

// void MinSumRowNumber(int[,] array)
// {
//     int[] tempArray = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         tempArray[i] = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             tempArray[i] = tempArray[i] + array[i, j];
//         }
//         System.Console.WriteLine(tempArray[i]); // вывод сумм строк массива
//     }
//     int minSumRow = 0;
//     for (int k = 1; k < tempArray.Length - 1; k++)
//     {
//         if (tempArray[k + 1] < tempArray[minSumInd])
//         {
//             minSumRow = k + 1;
//         }
//     }
//     System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSumRow + 1}");
// }

// int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
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
//             System.Console.Write(array[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// System.Console.Write("Input rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = CreateRandom2DArray(rows, columns, minValue, maxValue);
// Print2DArray(newArray);
// MinSumRowNumber(newArray);



// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] MultiplMatrix(int[,] firstMatrix, int[,] secondMatrix) // 2x2 matrix only
// {
//     int size = 2;
//     int[,] newMatrix = new int[size, size];
//     for (int i = 0; i < size; i++)
//     {
//         for (int j = 0; j < size; j++)
//         {
//             for (int k = 0; k < size-1; k++)
//             {
//                 for (int l = 1; l < size; l++)
//                 {
//                     newMatrix[i, j] = firstMatrix[i, k] * secondMatrix[k, j]
//                     + firstMatrix[i, l] * secondMatrix[l, j];
//                 }
//             }
//         }
//     }
//     return newMatrix;
// }

// int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
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
//             System.Console.Write(array[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input values to create 2x2 matrix");
// System.Console.Write("Input minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] firstMatrix = CreateRandom2DArray(2, 2, minValue, maxValue);
// int[,] secondMatrix = CreateRandom2DArray(2, 2, minValue, maxValue);
// System.Console.WriteLine("First matrix:");
// Print2DArray(firstMatrix);
// System.Console.WriteLine("Second matrix:");
// Print2DArray(secondMatrix);
// int[,] multipleMatrix = MultiplMatrix(firstMatrix, secondMatrix);
// System.Console.WriteLine("Final matrix:");
// Print2DArray(multipleMatrix);



// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] Create3DArray(int x, int y, int z, int minValue, int maxValue)
// {
//     int[,,] xyz = new int[x, y, z];
//     for (int i = 0; i < x; i++)
//     {
//         for (int j = 0; j < y; j++)
//         {
//             for (int k = 0; k < z; k++)
//             {
//                 xyz[i, j, k] = new Random().Next(minValue, maxValue);
//             }
//         }
//     }
//     return xyz;
// }

// void Print3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 System.Console.Write($"{array[i, j, k]} ({i}, {j}, {k})\t");
//             }
//             System.Console.WriteLine();
//         }
//     }
// }

// int[,,] array = Create3DArray(2, 2, 2, 1, 10);
// Print3DArray(array);




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int[,] CreateSpiralArray(int size)
// {
//     int[,] array = new int[size, size];
//     int count = 1;
//     int i = 0;
//     int j = 0;
//     while (count <= size * size)
//     {
//         array[i, j] = count;
//         count++;
//         if (i <= j + 1 && i + j < size - 1) j++;
//         else if (i < j && i + j >= size - 1) i++;
//         else if (i >= j && i + j > size - 1) j--;
//         else i--;
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// System.Console.Write("Input array size: ");
// int size = Convert.ToInt32(System.Console.ReadLine());
// int[,] spiral = CreateSpiralArray(size);
// Print2DArray(spiral);
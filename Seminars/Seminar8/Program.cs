// Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получается вот такой массив:

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7

// int[,] RowsToColumns(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         System.Console.WriteLine("Invalid input");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0) - 1; i++)
//         {
//             for (int j = i + 1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//         }
//     }
//     return array;
// }


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
//     System.Console.WriteLine();
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

// myArray = RowsToColumns(myArray);

// Print2DArray(myArray);


// Задание 3. Из двумерного массива целых чисел удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент

// int[,] DellRowsColumnsForMin(int[,] array)
// {
//     int min = array[0, 0];
//     int minRow = 0;
//     int minCol = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min)
//             {
//                 min = array[i, j];
//                 minRow = i;
//                 minCol = j;
//             }
//         }
//     }
//     for (int z = 0; z < array.GetLength(0); z++)
//     {
//         array[z, minCol] = 0;
//     }
//     for (int d = 0; d < array.GetLength(1); d++)
//     {
//         array[minRow, d] = 0;
//     }
//     return array;
// }


// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);

// myArray = DellRowsColumnsForMin(myArray);

// Print2DArray(myArray);



//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую
// и последнюю строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2


// int[,] ChangeRows(int[,] array, int firstRow, int secondRow)
// {
//     if (firstRow <= 0 || secondRow > array.GetLength(0)) System.Console.WriteLine("Invalid input!");
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         int temp = array[firstRow - 1, i];
//         array[firstRow - 1, i] = array[secondRow - 1, i];
//         array[secondRow - 1, i] = temp;
//     }
//     return array;
// }

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);

// Console.Write("Input first row to change ");
// int firstRow = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input second row to change ");
// int secondRow = Convert.ToInt32(Console.ReadLine());

// myArray = ChangeRows(myArray, firstRow, secondRow);

// Print2DArray(myArray);
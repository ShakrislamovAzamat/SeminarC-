// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue) //создание массива заполненного случайными числами
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// int CountEvenNumbers(int[] array) // возврат количества четных элементов массива
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count++;
//     }
//     return count;
// }

// void PrintArray(int[] array) // вывод на терминал массива
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Write("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input three-digit minValue ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input three-digit maxValue ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);

// int count = CountEvenNumbers(myArray);

// System.Console.WriteLine($"Количество четных элементов массива -> {count}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue) //создание массива заполненного случайными числами
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void PrintArray(int[] array) // вывод на терминал массива
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int SumNumUnevenPos(int[] array) // возврат суммы элементов, находящихся на нечетных позициях массива
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0) sum = sum + array[i];
//     }
//     return sum;
// }

// Console.Write("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input minValue ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input maxValue ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);

// int sum = SumNumUnevenPos(myArray);

// System.Console.WriteLine($"Сумма элементов нечетных позиций массива -> {sum}");


// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] CreateArray(int size) // заполнение элементов массива вручную
// {
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Введите число {i} элемента массива: ");
//         array[i] = Convert.ToDouble(Console.ReadLine());
//     }
//     return array;
// }

// double MinMaxDiff(double[] array)
// {
//     double dif = 0;
//     double min = array[0];
//     double max = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (min > array[i]) min = array[i];
//         if (max < array[i]) max = array[i];
//     }
//     return dif = max - min;
// }

// void PrintArray(double[] array) // вывод на терминал массива
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Write("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());

// double[] myArray = CreateArray(size);

// PrintArray(myArray);

// double diff = MinMaxDiff(myArray);

// System.Console.WriteLine($"Разность между максимальным и минимальным элементами массива -> {diff}");


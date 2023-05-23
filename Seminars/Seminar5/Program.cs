// Methods

int[] CreateRandomArray(int size, int minValue, int maxValue) //создание массива заполненного случайными числами
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void PrintArray(int[] array) // вывод на терминал массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void PosNegSum(int[] array) // нахождение сумм положительных и сумм отрицательных чисел массива
{
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0) sumPos += array[i];
        else sumNeg += array[i];
    }
    Console.WriteLine($"Sum of Positive elements -> {sumPos}, Sum of Negative elements -> {sumNeg}");
}

int[] InvertArray(int[] array) // инвертирование элементов массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

int[] CreateArray(int size) // заполнение элементов массива вручную
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите число {i} элемента массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

bool NumFind(int num, int[] array) // нахождение числа среди элементов массива
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}

int FindCount(int[] array, int minValue, int maxValue) // нахождение количества элементов массива, находящихся в определенном интервале
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= minValue && array[i] <= maxValue)
        count ++;
    }
    return count;
}


// Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// Console.Write("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input minValue ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input maxValue ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);

// PosNegSum(myArray);


//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// Console.Write("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input minValue ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input maxValue ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);

// myArray = InvertArray(myArray);

// PrintArray(myArray);


// //Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное
// число в массиве.

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input number to find: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray(size);
// PrintArray(myArray);

// if (NumFind(num, myArray)) Console.WriteLine($"Искомое число {num} имеется в массиве");
// else Console.WriteLine($"Искомое число {num} отсутствует");


//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].


Console.Write("Input array size ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input minValue ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input maxValue ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);

PrintArray(myArray);

int count = FindCount(myArray, 10, 99);

Console.WriteLine($"Количество элементов массива, лежащих в пределах от 10 до 99 -> {count}");
//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

// void ShowNumbers (int n)
// {
//     if (n>0)
//     {
//         ShowNumbers(n-1);
//         System.Console.Write(n+ " ");
//     }
// // System.Console.Write(n+ " ");
// }
// ShowNumbers(15);



//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

//453 -> 12
//45 -> 9

// int FindSum(int num)
// {
//     if (num > 0)
//     {
//         return FindSum(num / 10) + num % 10;
//     }
//     else return num;
// }

// System.Console.WriteLine(FindSum(6392));




//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

// void Numbers(int m, int n)
// {
//     if (m < n)
//     {
//         Numbers(m, n - 1);
//         System.Console.Write(n + " ");
//     }
//     else if (m > n)
//     {
//         Numbers(m - 1, n);
//         System.Console.Write(m + " ");
//     }
//     else System.Console.Write(n + " ");
// }

// Numbers(10, 20);



//Задача 4.Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

// int Exponential(int a, int b)
// {
//     if (b > 0)
//     {
//         return Exponential(a, b - 1) * a;
//     }
//     else return 1;
// }

// System.Console.WriteLine(Exponential(5, 5));
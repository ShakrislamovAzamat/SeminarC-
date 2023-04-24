//Напишите программу, которая выводит случайное число из отрезка [10, 99]
//и показывает наибольшую цифру числа

// int MaxDigit(int num)
// {
//     int dec = num / 10;
//     int ed = num % 10;
//     if (dec > ed) return dec;
//     else return ed;
// }

// int num = new Random().Next(10, 99 + 1);

// int result = MaxDigit(num);
// Console.WriteLine($"{num} -> {result}");


//Напишите программу, которая будет принимать на вход два числа и выводить,
//является ли второе число кратным первому. Если второе число не кратно числу
//первому, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4
//16, 4  -> кратно

// bool Kratnost (int num1, int num2)
// {
//     if (num1%num2 ==0) return true;
//     else return false;
// }

// Console.WriteLine("Input first number");
// int num1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num1}, {num2} -> {Kratnost(num1, num2)}, ost {num1%num2}");


// Напишите программу, которая принимает на вход число и проверяет,
//кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да

// bool Kratnost(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0) return true;
//     else return false;
// }
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num} -> {Kratnost(num)}");


// Напишите программу, которая принимает на вход два числа и проверяет,
//является ли одно число квадратом другого.

// bool Quad(int num1, int num2)
// {
//     if (num1 == num2*num2 || num2 == num1*num1) return true;
//     else return false;
// }

// Console.WriteLine("Input number1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num1}, {num2} -> {Quad(num1, num2)}");

// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// string Palindrom(int num)
// {
//     if ((num / 10000) != num % 10) return "нет";
//     num = (num / 10000) / 10;
//     if ((num / 100) != num % 10) return "нет";
//     else return "да";
// }

// Console.Write("input 5-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num} --> {Palindrom(num)}");


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Dist(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)), 2);
// }

// Console.WriteLine("Input coordinate X of A");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y of A");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z of A");
// double za = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate X of B");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y of B");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z of B");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between point A ({xa}, {ya}, {za}) and point B ({xb}, {yb}, {zb}) --> {Dist(xa, ya, za, xb, yb, zb)}");


// Задача 23. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Cubic(int num)
// {
//     int count = 1;
//     while (count <= num)
//     {
//         Console.Write($"{Math.Pow(count, 3)}; ");
//         count++;
//     }
// }

// Console.Write("Input N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Cubic(N);

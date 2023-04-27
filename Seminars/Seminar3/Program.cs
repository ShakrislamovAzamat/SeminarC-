//Задание1.  Напишите программу, которая принимает на вход координаты точки
// (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//в которой находится эта точка.

// int FindQuart(int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;
//     return 0;
// }

// Console.WriteLine("Input X");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input Y");
// int y = Convert.ToInt32(Console.ReadLine());

// int result = FindQuart(x,y);
// Console.WriteLine($"Point with {x} and {y} coordinates located at {result} quart");



//Задача 3. Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

// double FindDist(double xa, double ya, double xb, double yb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)), 2);
// }

// Console.WriteLine("Input coord X to A");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coord Y to A");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coord X to B");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coord Y to B");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Dist betwin point A with coord ({xa}, {ya}) and point B with coord ({xb}, {yb}) --> {FindDist(xa, ya, xb, yb)}");



//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает
//диапазон возможных координат точек в этой четверти (x и y).

// string Diapazone(int quart)
// {
//     if (quart == 1) return "x>0, y>0";
//     if (quart == 2) return "x<0, y>0";
//     if (quart == 3) return "x<0, y<0";
//     if (quart == 4) return "x>0, y<0";
//     return "Input correct quart";
// }

// Console.WriteLine("Input quart: ");
// int quart = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Range of possible coordinates for quart {quart} --> {Diapazone(quart)}");



//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на
//консоль квадраты чисел от 1 до N

// void Quad(int num)
// {
//     int count = 1;
//     while (count <= num)
//     {
//         Console.WriteLine($"{count} --> {Math.Pow(count, 2)}");
//         count++;
//     }
// }

// Console.Write("Input N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Quad(N);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты x1");
double numXa = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y1");
double numYa = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты x2");
double numXb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y2");
double numYb = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты x3");
double numXc = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y3");
double numYc = double.Parse(Console.ReadLine());


double rust = Math.Sqrt(Math.Pow((numYa - numXa), 2) + Math.Pow((numYb - numXb), 2) + Math.Pow((numYc - numXc),2) );
Console.WriteLine($"{rust}");


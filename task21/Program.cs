﻿Console.Clear();
Console.Write("x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("z2: ");
double z2 = double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2));
Console.WriteLine($"d={d:f2}");

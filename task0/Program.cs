// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double[]A = new double[3];
double[]B = new double[3];
Console.WriteLine("Введите координату x1: ");
A[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
A[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z1: ");
A[2] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
B[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
B[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z2: ");
B[2] = Convert.ToDouble(Console.ReadLine());

double length = Math.Sqrt(Math.Pow(B[0] - A[0],2) + Math.Pow(B[1] - A[1],2)+ Math.Pow(B[2] - A[2],2));
Console.WriteLine(length);

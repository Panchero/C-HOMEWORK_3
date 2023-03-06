// Задача 21
// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Программа для вычисления расстояния между двумя точками в 3D-пространстве");

Console.WriteLine("Введите координаты по оси X точки А");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты по оси Y точки А");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты по оси Z точки А");
double z1 = Convert.ToDouble(Console.ReadLine());  
Console.WriteLine("Введите координаты по оси X точки B");
double x2 = Convert.ToDouble(Console.ReadLine());  
Console.WriteLine("Введите координаты по оси Y точки B");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты по оси Z точки А");
double z2 = Convert.ToDouble(Console.ReadLine());  

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)); // корень(квадрат(данные, степень))
Console.WriteLine ("Расстояние между двумя точками в пространстве равно:");
Console.WriteLine(d.ToString("0.##"));
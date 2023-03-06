//  Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Программа для нахождения кубов чисел от единицы до заданного");
Console.WriteLine("Введите число: ");
int.TryParse(Console.ReadLine(), out int x);

double Func(int x)
{
    return Math.Pow(x, 3);
}

int i = 1;
while (i <= x)
{
    Console.Write(Func(i));
    if (i < x)
    Console.Write(", ");
    i++;
}
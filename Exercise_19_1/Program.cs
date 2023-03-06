﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом (НЕ использовать число как строку,
// то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ. 
// Используем операторы % и /).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число для проверки, программа проверит является ли оно палиндромом:");
int number = int.Parse(Console.ReadLine());
int pal = 0, num = number;
while (number > 0) {pal = pal * 10 + number % 10; number /= 10;}
Console.WriteLine(num == pal ? "палиндром" : "не палиндром");

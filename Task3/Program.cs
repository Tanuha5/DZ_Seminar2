﻿// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да 
// 7 -> да 
// 1 -> нет

System.Console.Write("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day == 1 || day == 2 || day == 3 || day == 4 || day == 5)
{
System.Console.WriteLine("Рабочий");
}
else if(day == 6 || day == 7)
{
System.Console.WriteLine("Выходной");
}
else
{
System.Console.WriteLine("Такого дня недели не существует");
}

﻿// Задача №12
// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит остаток
//  от деления.

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()??"0");

bool res = (num1%num2 == 0);

if (res)
{
  Console.WriteLine("первое число кратно второму");
}
else
{
  Console.WriteLine(num1%num2);
}
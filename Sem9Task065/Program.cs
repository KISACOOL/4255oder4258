﻿// Задача 65
// Задайте значения M и N. Напишите программу,
// которая найдёт все натуральные элементы 
// в промежутке от M до N.

int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

string RecMN(int m, int n)
{
  if(m <= n)
  {
  return m + "_" + RecMN(m + 1, n);
  }
  else{
    return string.Empty;
  }
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
Console.WriteLine (RecMN(m, n));
﻿// Задача 15:
// Напишите программу, которая принимает на вход цифру,обозначающую
// день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
// * Сделать вариант с использованием конструкции Dictionary

// Console.WriteLine("Введите номер дня");
// int day = int.Parse(Console.ReadLine()??"0");

// if (day < 1 || day > 7)

// // Во время семинара на доске, при решении этой задачи
// // была допущена ошибка, а именно вместо знака "||" (или)
// // был поставлен "&&" (и), но day не может быть и меньше одного
// // и больше семи одновременно))) 

// {
//   Console.WriteLine("это не день недели");
// }
// else
// {
//   if(day >= 1 && day <= 5)
//   {
//     Console.WriteLine("это рабочий день"); 
//   }
//   else
//   {
//     Console.WriteLine("это выходной день");
//   }
// } 

// Вариант 2*

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()??"0");

var dayWeek = new Dictionary<int,string>()
{ 
  {1, "monday"},
  {2, "tuesday"},
  {3, "wednesday"},
  {4, "Thursday"},
  {5, "friday"},
  {6, "saturday"},
  {7, "sunday"}
};

num = dayWeek
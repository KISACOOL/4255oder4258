﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов


// //Вариант 1
// // Метод читает данные от пользователя
// int ReadData(string msg)
// {
//   Console.WriteLine(msg);
//   int res = int.Parse(Console.ReadLine() ?? "0");
//   return res;
// }

// // Метод определяет является ли число полиндромом.
// bool PalTest (int num)
// {
//   bool res = false;
//   int D1 = num/10000;
//   int D5 = num%10;
//   int D2 = (num/1000)%10;
//   int D4 = (num/10)%10;
//   if (D1 ==D5 && D2 == D4)
//   res = true;
//   if (res == false) Console.WriteLine("число не является палиндромом");
//   if (res == true) Console.WriteLine("число является палиндромом"); 
//   return res;
// }

// int num = ReadData("Введите пятизначное число: ");
// // Проверяем является ли число пятизначным
// if (num > 10000 && num < 99999)
// {
//   Console.WriteLine(PalTest(num));
// }
// else
// {
//   Console.WriteLine("вы ввели не пятизначное число");
// }

// //  Я так и не понял как сделать так чтобы не выводилось значение "true" или "false".


// //Вариант 2(*)

// Создаем словарь
// Dictionary<int, string> numPal = new Dictionary<int, string>();

// numPal.Add(1001, "число является палиндромом");
// numPal.Add(1111, "число является палиндромом");
// numPal.Add(1221, "число является палиндромом");
// numPal.Add(1331, "число является палиндромом");
// numPal.Add(1441, "число является палиндромом");
// numPal.Add(1551, "число является палиндромом");
// numPal.Add(1661, "число является палиндромом");
// numPal.Add(1771, "число является палиндромом");
// numPal.Add(1881, "число является палиндромом");
// numPal.Add(1991, "число является палиндромом");
// numPal.Add(2002, "число является палиндромом");
// numPal.Add(2112, "число является палиндромом");
// numPal.Add(2222, "число является палиндромом");
// numPal.Add(2332, "число является палиндромом");
// numPal.Add(2442, "число является палиндромом");
// numPal.Add(2552, "число является палиндромом");
// numPal.Add(2662, "число является палиндромом");
// numPal.Add(2772, "число является палиндромом");
// numPal.Add(2882, "число является палиндромом");
// numPal.Add(2992, "число является палиндромом");
// numPal.Add(3003, "число является палиндромом");
// numPal.Add(3113, "число является палиндромом");
// numPal.Add(3223, "число является палиндромом");
// numPal.Add(3333, "число является палиндромом");
// numPal.Add(3443, "число является палиндромом");
// numPal.Add(3553, "число является палиндромом");
// numPal.Add(3663, "число является палиндромом");
// numPal.Add(3773, "число является палиндромом");
// numPal.Add(3883, "число является палиндромом");
// numPal.Add(3993, "число является палиндромом");
// numPal.Add(4004, "число является палиндромом");
// numPal.Add(4114, "число является палиндромом");
// numPal.Add(4224, "число является палиндромом");
// numPal.Add(4334, "число является палиндромом");
// numPal.Add(4444, "число является палиндромом");
// numPal.Add(4554, "число является палиндромом");
// numPal.Add(4664, "число является палиндромом");
// numPal.Add(4774, "число является палиндромом");
// numPal.Add(4884, "число является палиндромом");
// numPal.Add(4994, "число является палиндромом");
// numPal.Add(5005, "число является палиндромом");
// numPal.Add(5115, "число является палиндромом");
// numPal.Add(5225, "число является палиндромом");
// numPal.Add(5335, "число является палиндромом");
// numPal.Add(5445, "число является палиндромом");
// numPal.Add(5555, "число является палиндромом");
// numPal.Add(5665, "число является палиндромом");
// numPal.Add(5775, "число является палиндромом");
// numPal.Add(5885, "число является палиндромом");
// numPal.Add(5995, "число является палиндромом");
// numPal.Add(6006, "число является палиндромом");
// numPal.Add(6116, "число является палиндромом");
// numPal.Add(6226, "число является палиндромом");
// numPal.Add(6336, "число является палиндромом");
// numPal.Add(6446, "число является палиндромом");
// numPal.Add(6556, "число является палиндромом");
// numPal.Add(6666, "число является палиндромом");
// numPal.Add(6776, "число является палиндромом");
// numPal.Add(6886, "число является палиндромом");
// numPal.Add(6996, "число является палиндромом");
// numPal.Add(7007, "число является палиндромом");
// numPal.Add(7117, "число является палиндромом");
// numPal.Add(7227, "число является палиндромом");
// numPal.Add(7337, "число является палиндромом");
// numPal.Add(7447, "число является палиндромом");
// numPal.Add(7557, "число является палиндромом");
// numPal.Add(7667, "число является палиндромом");
// numPal.Add(7777, "число является палиндромом");
// numPal.Add(7887, "число является палиндромом");
// numPal.Add(7997, "число является палиндромом");
// numPal.Add(8008, "число является палиндромом");
// numPal.Add(8118, "число является палиндромом");
// numPal.Add(8228, "число является палиндромом");
// numPal.Add(8338, "число является палиндромом");
// numPal.Add(8448, "число является палиндромом");
// numPal.Add(8558, "число является палиндромом");
// numPal.Add(8668, "число является палиндромом");
// numPal.Add(8778, "число является палиндромом");
// numPal.Add(8888, "число является палиндромом");
// numPal.Add(8998, "число является палиндромом");
// numPal.Add(9009, "число является палиндромом");
// numPal.Add(9119, "число является палиндромом");
// numPal.Add(9229, "число является палиндромом");
// numPal.Add(9339, "число является палиндромом");
// numPal.Add(9449, "число является палиндромом");
// numPal.Add(9559, "число является палиндромом");
// numPal.Add(9669, "число является палиндромом");
// numPal.Add(9779, "число является палиндромом");
// numPal.Add(9889, "число является палиндромом");
// numPal.Add(9999, "число является палиндромом");

// Метод, возвращающий словарь четырехзначных палиндромов
Dictionary<int, int> FillPalindroms()
{
Dictionary<int, int> palindroms = new Dictionary<int, int>();

// Цикл внутри цикла, заполняющих значения словаря палиндромов
for (int i = 1; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        int key = j * 10 + i;
        int value = i * 1000 + j * 100 + j * 10 + i;
        palindroms.Add(key, value);
    }
}

return palindroms;
}
// Метод читает данные от пользователя
int ReadData(string msg)

{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

// Метод убирает среднюю цифру
int ChangeNum(int num)
{
  int res;
  int firstNum = num / 1000;
  int lastNum = num % 100;
  int newNum = firstNum * 100 + lastNum;
  res = newNum;
  return res;
}

int num = ReadData("Введите пятизначное число: ");
// // Проверяем является ли число пятизначным
if (num > 10000 && num < 99999)
{
  // Проверяем содержится ли измененное число в словаре.
  if (numPal.ContainsKey(ChangeNum(num)))
  {
    Console.WriteLine(numPal[ChangeNum(num)]);
  }
  else
  {
    Console.WriteLine("число не является палиндромом");
  }
}
else
{
  Console.WriteLine("вы ввели не пятизначное число");
}

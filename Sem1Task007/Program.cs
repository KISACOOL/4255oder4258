﻿Console.WriteLine("Введите трехзначное число");

string? numLine = Console.ReadLine();

if (numLine != null)
{
  //char[] charArr = numLine.ToCharArray();

  //Console.WriteLine(charArr[charArr.Line - 1]);

  int num = int.Parse(numLine);
  int res = num%10;

  Console.WriteLine(res);
}
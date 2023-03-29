// Задача 8: 
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int numN = int.Parse(Console.ReadLine()??"0");
int startNum = 1;
string res = string.Empty;

while (startNum <= numN)
{
  if (startNum % 2 == 0)
  {
    res = startNum + " ";
    Console.Write(res);
  }
  startNum++;
}

// Я её решил но остались вопросы.

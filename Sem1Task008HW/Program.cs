// Задача 8: 
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Вариант 1
// Console.WriteLine("Введите число");
// int numN = int.Parse(Console.ReadLine()??"0");
// int startNum = 1;
// string res = string.Empty;

// while (startNum <= numN)
// {
//   if (startNum % 2 == 0)
//   {
//     res = startNum + "_";
//     Console.Write(res);
//   }
//   startNum++;
// }

// Я её решил но остается куча вопросов.

//Вариант 2

Console.WriteLine("Введите число");
int numN = int.Parse(Console.ReadLine()??"0");
int startNum = 1;
string digits = string.Empty;

 while (startNum <= numN)
  {
   digits = digits + startNum;
   startNum++;
  } 
  Console.WriteLine(digits);

char[] res = digits.ToString().ToCharArray();

Console.WriteLine(res%2 == 0);


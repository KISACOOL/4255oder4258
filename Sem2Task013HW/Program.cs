// Задача 13: 
// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// * Сделать вариант для числа длиной до 10 цифр
//  не используя char или string

// Вариант 1

// string num = Console.ReadLine();
// char[] arr = num.ToCharArray();
// if(arr.Length>=3)
// {
//   Console.WriteLine(arr[2]);
// }
// else
// {
//   Console.WriteLine("третей цифры нет");
// }

// Вариант 2*

// System.Random numSintezator = new System.Random();
// long rndNum = numSintezator.Next(10,1000000000);
// Console.WriteLine(rndNum);

// Это я пробывал с рандомайзером, но он не хочет делать
// короткие числа, поэтому решил сделать ручной ввод)

// Вариант 2*.1

// Console.WriteLine("Введите число");
// int rndNum = int.Parse(Console.ReadLine()??"0");

// // Возможно стоило изменить имя переменной... 

// if (rndNum < 100)
// {
//   Console.WriteLine("третей цифры нет");
// }
// else
// {
//   if(rndNum > 100 && rndNum < 1000)
//   {
//     Console.WriteLine(rndNum%10); 
//   }
//   if(rndNum > 1000 && rndNum < 10000)
//   {
//     Console.WriteLine((rndNum/10)%10); 
//   }
//   if(rndNum > 10000 && rndNum < 100000)
//   {
//     Console.WriteLine((rndNum/100)%10); 
//   }
//   if(rndNum > 100000 && rndNum <  1000000)
//   {
//     Console.WriteLine((rndNum/1000)%10); 
//   }
//   if(rndNum > 1000000 && rndNum < 10000000)
//   {
//     Console.WriteLine((rndNum/10000)%10); 
//   }
//   if(rndNum > 10000000 && rndNum < 100000000)
//   {
//     Console.WriteLine((rndNum/100000)%10); 
//   }
//   if(rndNum > 100000000 && rndNum < 1000000000)
//   {
//     Console.WriteLine((rndNum/1000000)%10); 
//   }
// }

// Условия я конечно выполнил но это такая зелибоба получилась)))

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine() ?? "0");
int lengthNum = (int)Math.Log10(number);

// Сначала попробывал преоброзовать при помощи 
// "Convert.ToInt32(Math.Log10(number))", но при
// преоброзовании он учитывал десятые и на выходе получались разные цифры.

if (lengthNum < 2)
{
  Console.WriteLine("третей цифры нет");
}
else
{
  int res = 1;
  int count = 3;
  while (count <= lengthNum)
  {
    res = res * 10;
    count++;
  }
Console.WriteLine((number/res)%10);
}

// Вроде чего-то получилось))) Названия переменных мне ненравятся.


// int num = int.Parse(Console.ReadLine()??"0");

// int res = num;

// if (num <100 )

// Console.Write("The 3rd number does not exist");

// else
// {
    

// while (res >= 1000)
// {
//     res = res /10;
 
// }

// res = res%10;
// }
// Console.Write( res );
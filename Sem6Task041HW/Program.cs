// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа
// следит за нажатиями и выдает сколько чисел больше 0 
// было введено.


// Вариант 1

// Метод читает данные от пользователя и преобразует их в массив. 
// int[] ReadData(string msg)
// {
//   Console.WriteLine(msg);
//   int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
//   return arr;
// }

// // Метод считающий сколько чисел больше 0 в одномерном массиве.
// int CountPosNum(int[] arr) 
// {
//   int sum = 0;
//   for(int i = 0; i < arr.Length; i++ )
//   {
//     if(arr[i] > 0) sum = sum + 1; 
//   }
//   return sum;
// }

// int[] numbers = ReadData("Введите числа через пробел: ");
// Console.WriteLine(CountPosNum(numbers));

// Вариант 2 "подсмотренный"
Console.WriteLine("Введите элементы (через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int count = arr.Count(x => x > 0);
Console.WriteLine($"Колличество эллементов > 0: {count}");
/////////////////////////////////////////////////////////

// Задача 41*

// //без явного указания сборки не работают регулярные выражения.
// using System.Text.RegularExpressions;

// int taps = ReadData("Введите количество нажатий");
// string inputLine = ReadLineData("Введите любые символы с клавиатуры.");
// Console.WriteLine(inputLine);
// FindNumbersInString(inputLine, taps);
// //Методы:

// //метод запрашивает и ситывает данные с консоли
// int ReadData(string msg)
// {
//   Console.WriteLine(msg);
//   return int.Parse(Console.ReadLine() ?? "0");
// }

// //метод считывает нажатие клавиш на клавиатуре заданное количество раз 
// // и собирает данные в строку через запятую
// string ReadLineData(string msg)
// {
//   Console.WriteLine(msg);
//   string line = "";
//   for (int i = 0; i < taps; i++)
//   {
//     //параметр true указан для того, чтобы после нажатия клавишь
//     //ничего не появлялось в консоли
//     var key = Console.ReadKey(true);
//     line = line + String.Format(key.KeyChar.ToString()) + ",";
//   }
//   line = line.TrimEnd(','); //кусь последнюю запятую
//   return line;
// }
// //метод для поиска десятичных цифр в строке с помощью регулярных выражений
// void FindNumbersInString(string str, int count)
// {
//   Regex regex = new Regex(@"\d");//задаем для поиска параметр "любая десятичная цифра"
//   MatchCollection matches = regex.Matches(str); //задаем коллекциюЮ состоящую из найденных по условию выражений 
//   int posNums = 0;
//   if (matches.Count > 0) //если цифры найдены, то накапливаем результат. Каждая найденная цифра +1 к итогу.
//   {
//     foreach (Match match in matches)
//     {
//       posNums = posNums + 1;
//     }
//     Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов найдено чисел: {posNums}");
//   }
//   else
//   {
//     Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов чисел не найдено");
//   }
// }

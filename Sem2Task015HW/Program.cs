// Задача 15:
// Напишите программу, которая принимает на вход цифру,обозначающую
// день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
// * Сделать вариант с использованием конструкции Dictionary

// Вариант 1

// Console.WriteLine("Введите номер дня");
// int day = int.Parse(Console.ReadLine()??"0");

// if (day < 1 || day > 7)

// // // Во время семинара на доске, при решении этой задачи
// // // была допущена ошибка, а именно вместо знака "||" (или)
// // // был поставлен "&&" (и), но day не может быть и меньше одного
// // // и больше семи одновременно))) 

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

Dictionary<int, string> daysOfWeek = new Dictionary<int, string>();

daysOfWeek.Add(1, "monday - рабочий день");
daysOfWeek.Add(2, "tuesday - рабочий день");
daysOfWeek.Add(3, "wednesday - рабочий день");
daysOfWeek.Add(4, "Thursday - рабочий день");
daysOfWeek.Add(5, "friday - рабочий день");
daysOfWeek.Add(6, "saturday - выходной день");
daysOfWeek.Add(7, "sunday - выходной день");

Console.WriteLine("Введите номер дня");
int day = int.Parse(Console.ReadLine() ?? "0");

if (daysOfWeek.ContainsKey(day))
{
  Console.WriteLine(daysOfWeek[day]);
}
else
{
  Console.WriteLine("это не день недели");
}

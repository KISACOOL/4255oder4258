// Задача 15:
// Напишите программу, которая принимает на вход цифру,обозначающую
// день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
// * Сделать вариант с использованием конструкции Dictionary

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
Console.WriteLine("Введите номер дня");
int day = int.Parse(Console.ReadLine()??"0");
void Week(int args)
{
Dictionary<int,string> WeekList = new Dictionary<int,string>();

  WeekList.Add(1, "monday");
  WeekList.Add(2, "tuesday");
  WeekList.Add(3, "wednesday");
  WeekList.Add(4, "Thursday");
  WeekList.Add(5, "friday");
  WeekList.Add(6, "saturday");
  WeekList.Add(7, "sunday");
  string value = "";

Console.WriteLine(value);
}
 
Week(day);

// static void Main(string[] args)
//         {
//             Dictionary<string, string> AuthorList = new Dictionary<string, string>();
 
//             AuthorList.Add("ggt", "гистидин");
//             AuthorList.Add("ggg", "фенилаланин");
//             AuthorList.Add("ctg", "глицин");
//             AuthorList.Add("ttt", "глицин");
//             string value = "";
//             if (AuthorList.TryGetValue("ttt", out value))
//             {
//           Console.WriteLine(value);      
//             }
//             Console.ReadKey();
//         }
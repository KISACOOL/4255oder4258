// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом

// Вариант 1

// Метод читает данные от пользователя
// int ReadData(string msg)
// {
//   Console.WriteLine(msg);
//   int res = int.Parse(Console.ReadLine() ?? "0");
//   return res;
// }

// // Метод рисующий строки с числом и его кубы.
// string LineGen(int num, int pow)
// {
//   string res = "║"; // String.Empty;
//   for(int i=1; i<=num; i++)
//   {
//     res += Math.Pow(i,pow) + "\t║";
//   }
//   return res;
// }
// // Метод рисующий верхнюю, среднюю и нижнюю границы.
// string TableLineBuilder(int num, string linePosition)
// {
//   string res = String.Empty; int i; switch (linePosition)
//   {
//     case "top": res = "╔"; for (i = 1; i < num; i++) res = res + "═══════╦"; res = res + "═══════╗"; break;   
//     case "middle": res = "╠"; for (i = 1; i < num; i++) res = res + "═══════╬"; res = res + "═══════╣ " ;break; 
//     case "bottom": res = "╚"; for (i = 1; i < num; i++) res = res + "═══════╩"; res = res + "═══════╝"; break;
//     default: for (i = 1; i < num; i++) res = res + "════"; break;
//   }
//   return res;
// }

// int num = ReadData("Введите число N: ");
// Console.WriteLine (TableLineBuilder (num,"top"));
// Console.WriteLine (LineGen (num,1));
// Console.WriteLine (TableLineBuilder (num,"middle"));
// Console.WriteLine (LineGen (num,3));
// Console.WriteLine (TableLineBuilder (num,"bottom"));

// Тот пример который был дан на занятии я изоброзил))) пробуем дальше...
// ╣ ╠ ╬ ╔ ╗ ╚ ╝ ╩ ╦

// Вариант 2

// Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

// Метод определяющий строки с числами и кубами.
string LineGen(int topNum, int pow, string initLine)
{
  string resLine = initLine;
  int cube = 0;
  for(int i=1; i<= topNum; i++)
  {
    cube = (int)Math.Pow(i,3);
    resLine = resLine + ((pow == 3)?cube.ToString():((i).ToString()).PadRight((int)Math.Log10(cube) + 1)) + "\u2551";
  }
  return resLine;
}

// Метод определяющий верхнюю, среднюю и нижнюю строку.
void DrawUniLine (string sampleStr, string startSym, string midSym, string stopSym)
{
  Console.Write (startSym);
  int i = 1;
  while(i < sampleStr.Length - 1)
  {
    if (sampleStr[i] == '\u2551')Console.Write(midSym);
    else Console.Write("\u2550");
    i++;
  }
  Console.WriteLine(stopSym);
}
int topNum = ReadData("Введите число N: ");
string firstStr = LineGen(topNum,1,"\u2551 Число:    \u2551");
string secStr = LineGen(topNum,3,"\u2551 Куб числа:\u2551");

DrawUniLine(secStr, "\u2554", "\u2566", "\u2557");
Console.WriteLine (firstStr);
DrawUniLine(secStr, "\u2560", "\u256C", "\u2563");
Console.WriteLine (secStr);
DrawUniLine(secStr, "\u255A", "\u2569", "\u255D");

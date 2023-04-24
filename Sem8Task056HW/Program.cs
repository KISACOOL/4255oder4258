// Задача 56:
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов:
// 1 строка

int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

int[,] Gen2DArr(int countRow, int countColumn, int minValue, int maxValue)
{
  int[,] arr = new int[countRow, countColumn];
  for (int i = 0; i < countRow; i++)
  {
    for (int j = 0; j < countColumn; j++)
    {
      arr[i, j] = new Random().Next(minValue, maxValue + 1);
    }

  }
  return arr;
}

void Print2DArr(int[,] arr)
{
  ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.ForegroundColor = col[new Random().Next(0, 16)];
      Console.Write(arr[i, j] + " ");
      Console.ResetColor();
    }
    Console.WriteLine();
  }
}

int MinSumRaw(int[,] arr)
{
  int outN = 0;
  int sum = int.MaxValue;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
    int sumRaw = 0;
    for(int j = 0; j < arr.GetLength(1); j++)
    {
      sumRaw = sumRaw + arr[i,j];
    }
    if(sumRaw < sum)
    {
    sum = sumRaw;
    outN = i + 1;
    }
    }
    
  return outN;
}

int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArr(row, col, 0, 9);
Print2DArr(arr2D);
int line = MinSumRaw(arr2D);
Console.Write("номер строки с наименьшей суммой элементов: ");
Console.WriteLine(line);



// Задача 54:
// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortArr(int[,] arr)
{
  int[] buf = new int[arr.GetLength(1)];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      buf[j] = arr[i, j];

      // int max = arr.Max();
      // int min = arr.Min();

      // int[] count = new int[max - min + 1];
      // int z = 0;

      // for (int i = 0; i < arr.Length; i++)
      // {
      //   count[arr[i] - min]++;
      // }
      // for (int i = min; i <= max; i++)
      // {
      //   while (count[i - min]-- > 0)
      //   {
      //     arr[z] = i;
      //     z++;
      //   }
    }
    }
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        arr[i, j] = buff[j];
      }
    }
  }
}

int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArr(row, col, 10, 99);
Print2DArr(arr2D);
SortArr(arr2D);
Print2DArr(arr2D);
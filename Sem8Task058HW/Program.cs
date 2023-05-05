// Задача 58:
// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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


int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] firstArr2D = Gen2DArr(row, col, 1, 10);
Print2DArr(firstArr2D);
Console.WriteLine();
int[,] secondArr2D = Gen2DArr(row, col, 1, 10);
Print2DArr(secondArr2D);

int[,] resultArray = new int[row,col];
if(firstArr2D.GetLength(0) != secondArr2D.GetLength(1))
{
  Console.WriteLine("Нельзя перемножить" );
  return;
}
for(int i = 0; i < firstArr2D.GetLength(0); i++)
  {
    for(int j = 0; j < secondArr2D.GetLength(1); j++)
    {
      resultArray[i,j] = 0;
      for(int k = 0; k < firstArr2D.GetLength(1); k++)
      {
        resultArray[i,j] += firstArr2D[i,k] * secondArr2D[k,j];
      }
    }
  }

  Print2DArr(resultArray);
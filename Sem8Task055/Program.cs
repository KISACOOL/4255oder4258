// Задача №55
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести
// сообщение для пользователя.

//Метод ввода
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

int[,] Gen2DArr(int countRow, int countColumn, int minValue, int maxValue)
{
  int[,] arr = new int[countRow, countColumn];
  for(int i = 0; i < countRow; i++)
  {
    for(int j = 0; j < countColumn; j++)
    {
      arr[i,j] = new Random().Next(minValue,maxValue + 1);
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
  for(int i = 0; i < arr.GetLength(0); i++)
  {
    for(int j = 0; j < arr.GetLength(1); j++)
    {
      Console.ForegroundColor = col[new Random().Next(0,16)];
      Console.Write(arr[i, j] + " ");
      Console.ResetColor();
    }
  Console.WriteLine();  
  }
}

int[,] Transp(int[,] matr)
{
  int[,] outMatr = new int[matr.GetLength(0),matr.GetLength(1)];
  for(int i = 0; i < matr.GetLength(0); i++)
  {
    for(int j = 0; j < matr.GetLength(1); j++)
    {
      outMatr[j,i] = outMatr[i,j];
    }
  }
   return outMatr; 
}

int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArr(row, col, 10, 99);
Print2DArr(arr2D);
int[,] arr = Transp(arr2D);
Print2DArr(arr);
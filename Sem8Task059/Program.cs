// Задача №59
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен
// наименьший элемент массива.

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

int[] FindMinElem(int[,] mtr)
{
  int[] outA = new int[2];
  int minElm = int.MaxValue;
    for(int i = 0; i < mtr.GetLength(0); i++)
  {
    for(int j = 0; j < mtr.GetLength(1); j++)
    {
      if(minElm > mtr[i,j])
      {
        minElm = mtr[i,j];
        outA[0] = i;outA[1] = j;
      }
    }
  }
  return outA;
}

int[,] ReGen2DArr(int[,] mtr, int[] point)
{
  int[,] outM = new int[mtr.GetLength(0) - 1, mtr.GetLength(1) - 1];
  int k = 0;
  int m =0;
  for(int i = 0; i < mtr.GetLength(0); i++)
  {
    m = 0;
    for(int j = 0; j < mtr.GetLength(1); j++)
    {
      if(i != point[0] && j != point[1])
      {
        outM[k,m] = mtr[i,j];
        m++;
      }
      if(i != point[0])
      {
        k++;
      }
    }
  }
  return outM;
}

int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArr(row, col, 10, 99);
Print2DArr(arr2D);
 Console.WriteLine();
int[] point = FindMinElem(arr2D);
int[,] outMatr = ReGen2DArr(arr2D,point);
Print2DArr(outMatr);
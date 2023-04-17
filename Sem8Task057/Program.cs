// Задача №57
// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается
// элемент входных данных.

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

int[] FreqArr(int[,] arr, int count)
{
  int[] outArr = new int[count];
    for(int i = 0; i < arr.GetLength(0); i++)
  {
    for(int j = 0; j < arr.GetLength(1); j++)
    {
      outArr[arr[i,j]]++;
    }
  
  }
  return outArr;
}

void Print1DArray(int[] arr)

{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int row = ReadData("Введите кол-во строк: ");
int col = ReadData("Введите кол-во столбцов: ");
int[,] arr2D = Gen2DArr(row, col, 0, 9);
Print2DArr(arr2D);
int[] arrFreq = FreqArr(arr2D);
Print1DArray(arrFreq);

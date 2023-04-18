// Задача 52.
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// * Дополнительно диагональ выделить разным цветом.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.




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
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
  }
}

// Метод печати массива c вещественными числами
void Print1DArr(double[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + "| ");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

double[] ColMean(int[,] arr)
{
  double[] mean = new double[arr.GetLength(1)];
  for (int j = 0; j < arr.GetLength(1); j++)
  {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      mean[j] += arr[i, j];
    }
    mean[j] = mean[j] / arr.GetLength(0);
  }
  return mean;
}

void ColorDiagArr(int[,] arr)
{
  ConsoleColor[] color = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    if (i % 2 == 0)
    {
      for (int j = 0; j < arr.GetLength(1); j = j + 2)
      {
        Console.ForegroundColor = color[new Random().Next(0,1)];
        Console.Write(arr[i, j] + " ");
        Console.ResetColor();
      }
    }
    else
    {
      // i++;
      for (int j = 1; j < arr.GetLength(1); j = j + 2)
      {
        Console.ForegroundColor = color[new Random().Next(2,3)];
        Console.Write(arr[i, j] + " ");
        Console.ResetColor();
      }
    }
    Console.WriteLine();
  }
}

int row = ReadData("Введите колличество строк: ");
int col = ReadData("Введите колличество столбцов: ");
int[,] arr2D = Gen2DArr(row, col, 10, 99);
double[] arr = ColMean(arr2D);
// ConsoleColor col1 = ReadData("Введите цвет первой диогонали: ");
// ConsoleColor col2 = ReadData("Введите цвет второй диогонали: ");
ColorDiagArr(arr2D);

Print1DArr(arr);
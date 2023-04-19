// Задача 47.
// Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.
// * При выводе матрицы показывать каждую цифру 
// разного цвета(цветов всего 16)
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// //Метод ввода
// int ReadData(string msg)
// {
//   Console.WriteLine(msg);
//   int res = int.Parse(Console.ReadLine() ?? "0");
//   return res;
// }

double[,] Gen2DArr(int countRow, int countColumn, int minValue, int maxValue)
{
  double[,] arr = new double[countRow, countColumn];
  for(int i = 0; i < countRow; i++)
  {
    for(int j = 0; j < countColumn; j++)
    {
      arr[i,j] = new Random().Next(minValue,maxValue + 1) + new Random().NextDouble();
    }
  
  }
  return arr;
}

void Print2DArr(double[,] arr)
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
      char[] nambers = arr[i,j].ToString().ToCharArray();
      for(int k = 0; k < nambers.Length; k++)
      {
      Console.ForegroundColor = col[new Random().Next(0,16)];
      Console.Write(nambers[k]);
      Console.ResetColor();
      }
      Console.Write(" ");
    }
  Console.WriteLine();  
  }
}

// int row = ReadData("Введите кол-во строк: ");
// int col = ReadData("Введите кол-во столбцов: ");
double[,] arr2D = Gen2DArr(3, 3, 10, 99);
Print2DArr(arr2D);


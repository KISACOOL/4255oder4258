﻿// Задача 50.
// Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// int ReadData(string msg)
// {
//   Console.WriteLine(msg);
//   int res = int.Parse(Console.ReadLine() ?? "0");
//   return res;
// }

// int[,] Gen2DArr(int countRow, int countColumn, int minValue, int maxValue)
// {
//   int[,] arr = new int[countRow, countColumn];
//   for(int i = 0; i < countRow; i++)
//   {
//     for(int j = 0; j < countColumn; j++)
//     {
//       arr[i,j] = new Random().Next(minValue,maxValue + 1);
//     }
  
//   }
//   return arr;
// }

// void Print2DArr(int[,] arr)
// {
//   ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                         ConsoleColor.Yellow};
//   for(int i = 0; i < arr.GetLength(0); i++)
//   {
//     for(int j = 0; j < arr.GetLength(1); j++)
//     {
//       Console.ForegroundColor = col[new Random().Next(0,16)];
//       Console.Write(arr[i, j] + " ");
//       Console.ResetColor();
//     }
//   Console.WriteLine();  
//   }
// }

// void FindElm(int[,] arr, int x, int y)
// {
//   if(x > arr.GetLength(0) || y > arr.GetLength(1))
//   {
//     Console.WriteLine("Такого элемента нет");
//   }
//   else
//   {
//     Console.WriteLine(arr[x,y]);
//   } 
// }

// int row = ReadData("Введите колличество строк: ");
// int col = ReadData("Введите колличество столбцов: ");
// int[,] arr2D = Gen2DArr(row, col, 10, 99);
// Print2DArr(arr2D);
// int rowNum = ReadData("Введите значение строки: ");
// int colNum = ReadData("Введите значение столбца: ");
// FindElm(arr2D,rowNum,colNum);


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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

void FindElm(int[,] arr, int x, int y)
{
  if(x > arr.GetLength(0) || y > arr.GetLength(1))
  {
    Console.WriteLine("Такого элемента нет");
  }
  else
  {
    Console.WriteLine(arr[x,y]);
  } 
}

int row = ReadData("Введите колличество строк: ");
int col = ReadData("Введите колличество столбцов: ");
int[,] arr2D = Gen2DArr(row, col, 10, 99);
Print2DArr(arr2D);
int rowNum = ReadData("Введите значение строки: ");
int colNum = ReadData("Введите значение столбца: ");
FindElm(arr2D,rowNum,colNum);

// Метод заполнения 2х-мерного массива числами Фибоначчи :
long[,] Fibonacci2Darr(int countRow, int countColumn)
{
    long[,] arr = new long[countRow, countColumn];
    long first = 0;
    long last = 1;
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            if (j < 2)
            {
                arr[0, 0] = 0;
                arr[0, 1] = 1;
            }
            else
            {
                arr[i, j] = (first + last);
                (first, last) = (last, first + last);
            }
        }
    }
    return arr;
}
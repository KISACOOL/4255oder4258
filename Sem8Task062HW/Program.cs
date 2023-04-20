// Задача 62.
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


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

// int ReadData(string msg)
// {
//   Console.WriteLine(msg);
//   int res = int.Parse(Console.ReadLine() ?? "0");
//   return res;
// }

// int[,] sqareMatrix(int countRow, int countColumn)
// {
//   int m = countRow;
//   int n = countColumn;
//   int[,] arr = new int[m, n];
//   int num = 1;
 
//   for(int i = 0; i < n; i++)
//   {
//     arr[0,i] = num;
//     num++;
//   }
//     for(int j = 1; j < m; j++)
//   {
//     arr[j, n - 1] = num;
//     num++;
//   }
//     for(int i = n - 2; i >= 0; i--)
//   {
//     arr[m - 1,i] = num;
//     num++;
//   }
//     for(int j = m - 2; j > 0; j--)
//   {
//     arr[j,0] = num;
//     num++;
//   }

//   int c = 1;
//   int d = 1;

//   while(num < m * n)
//   {
//     while(arr[c,d + 1] == 0)
//     {
//       arr[c,d] = num;
//       num++;
//       d++;
//     }
//        while(arr[c + 1,d] == 0)
//     {
//       arr[c,d] = num;
//       num++;
//       c++;
//     }
//         while(arr[c,d - 1] == 0)
//     {
//       arr[c,d] = num;
//       num++;
//       d--;
//     }
//         while(arr[c - 1,d] == 0)
//     {
//       arr[c,d] = num;
//       num++;
//       c--;
//     } 
//   }

//   for(int j = 0; j < m; j++)
//   {
//     for(int i = 0; i < n; i++)
//     {
//       if (arr[j,i] == 0)
//       {
//         arr[j,i] = num;
//       }
//     }
//   }
//   return arr;
// }

// void WriteArray(int[,] arr)
// {
//   for (int i = 0; i < arr.GetLength(0); i++)
//   {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//       if (arr[i, j] <10)
//       {
//         Console.Write($"{arr[i, j]}");
//       }
//     }
//     Console.WriteLine();
//   }
// }

// int row = ReadData("Введите колличество строк: ");
// int col = ReadData("Введите колличество столбцов: ");
// int[,] spirArr = sqareMatrix(row, col);
// WriteArray(spirArr);



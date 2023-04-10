// Задача №39
// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый
// - на последнем и т.д.)

// void Print2DArr(int[,] matr)
// {
//   for(int i = 0; i < matr.GetLength(0); i++)
//   {
//     for(int j = 0; j < matr.GetLength(1); j++)
//     {
//       Console.Write($"{matr[i, j]}"); 
//     }
//   Console.WriteLine();  
//   }
// }


// void Fill2DArr(int[,] matr)
// {
//   for(int i = 0; i < matr.GetLength(0); i++)
//   {
//     for(int j = 0; j < matr.GetLength(1); j++)
//     {
//       matr[i, j] = new Random().Next(1,10); 
//     }
//   }
// }
// int[,] matrix = new int[3, 4];
// Print2DArr(matrix);
// Fill2DArr(matrix);
// Print2DArr(matrix);

//Метод генерирует  
int[] Gen1DArr(int len, int but, int top)
{
  if(but > top)
  {
    int buf = but;
    but = top;
    top = buf;
  }
  Random rnd = new Random();
  int[] arr = new int[len];
  for(int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(but, top + 1); 
  }
  return arr;
}

// Метод печати массива
void Print1DArr(int[] arr)
{
  Console.Write("[");
  for(int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ", ");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Метод разворачивающий массив 1
void SwapArr(int[] arr) 
{
  for(int i = 0; i < arr.Length/2; i++ )
  {
    //(arr[i], arr[arr.Length - 1 -i]) = ()
    int buf = arr[1];
    arr[i] = arr[arr.Length - 1 -i];
    arr[arr.Length - 1 -i] = buf;
  }
}
// Метод разворачивающий массив 2
int[] SwapNewArr(int[] arr) 
{
  int[] outArr = new int[arr.Length];
  for(int i = 0; i < arr.Length - 1; i++ )
  {
    outArr[outArr.Length -1 -i] = arr[i];
  }
  return outArr;
}

int[] testArray = Gen1DArr(12,10,100);
Print1DArr(testArray);

DateTime d1 = DateTime.Now;
int[] newArray = SwapNewArr
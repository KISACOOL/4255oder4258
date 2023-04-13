// Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю

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

// Метод вычесляющий сумму элементов 
// стоящих на нечетных позициях в массиве.
int OddIndElmSum(int[] arr)
{
  int res = 0;
  for(int i = 1; i < arr.Length; i=i+2)
  {
    res += arr[i];
  }
  return res;
}

int[] arr = Gen1DArr(10,0,99); 
Print1DArr(arr);
int res = OddIndElmSum(arr);
Console.WriteLine("Сумма чисел, стоящих на нечетных позициях в массиве: " + res);

// /////////////////////////////////////////////////////////////////////////////////////

// // Задача 36*

// int[] Gen1DArr(int len, int but, int top)
// {
//   if(but > top)
//   {
//     int buf = but;
//     but = top;
//     top = buf;
//   }
//   Random rnd = new Random();
//   int[] arr = new int[len];
//   for(int i = 0; i < arr.Length; i++)
//   {
//     arr[i] = rnd.Next(but, top + 1); 
//   }
//   return arr;
// }

// //Метод печатает массив
// void Print1DArr(int[] arr)
// {
//   Console.Write("[");
//   for(int i = 0; i < arr.Length - 1; i++)
//   {
//     Console.Write(arr[i] + ",");
//   }
//   Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// void FindPair(int[] arr)
// {
//   // int first = arr[0];
  
//   for(int i = 1; i < arr.Length; i++)
//   {
//     if(arr[i - 1] == arr[i])
     
//     {
//       Console.Write("(" + arr[i - 1] + "," + arr[i] + ")" + ",");
//     }
//     // else
//     // {
//     //   Console.Write("Пар не обнаружено!");
//     // }
//   }
// }


// int[] arr = Gen1DArr(10,0,5); 
// Print1DArr(arr);
// FindPair(arr);

// // void FindPair(int[] arr)
// // {
// //   int n = arr[0];
// //   for(int i = 0; i < arr.Length; i++)
// //   {
// //     for(int j = 0; j < arr.Length; j++)
// //     {
// //       Console.Write("(" + arr[i] + "," + ")" + ",");
// //     }
// //   }

// // }



// // int[] arr = Gen1DArr(10,0,99); 
// // Print1DArr(arr);
// // FindPair(arr);
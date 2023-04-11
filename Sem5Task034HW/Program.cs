// Задача 34:
// Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая
// покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// * Отсортировать массив методом пузырька и подсчета.
// Сравнить быстродействие методов. Проверку сортировки
// производить отдельно. Сначало запустить программу
// с одним методом сортировки, а затем с другим.
// Проверять на длине массива не мение 10000 элементов.

//Метод генерирует  
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
// // Метод печати массива
// void Print1DArr(int[] arr)
// {
//   Console.Write("[");
//   for(int i = 0; i < arr.Length - 1; i++)
//   {
//     Console.Write(arr[i] + ", ");
//   }
//   Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// // // Метод вычесляющий сумму четных в массиве)))
// // // эт я немного тупанул, правда, я изначально
// // // не правильно услышал условия задачи.

// // int EvenSum(int[] arr)
// // {
// //   int res = 0;
// //   for(int i = 0; i < arr.Length; i++)
// //   {
// //     if(arr[i]%2 == 0)
// //     {
// //       res += arr[i];
// //     }
// //   }
// //   return res;
// // }

// // // Метод вычесляющий количество четных в массиве)))
// // // прикольно, пришлось поменять название и одну
// // цифурку в педыдущем.

// int EvenCount(int[] arr)
// {
//   int res = 0;
//   for(int i = 0; i < arr.Length; i++)
//   {
//     if(arr[i]%2 == 0)
//     {
//       res ++;
//     }
//   }
//   return res;
// }

// int[] arr = Gen1DArr(10,100,999); 
// Print1DArr(arr);
// int res = EvenCount(arr);
// Console.WriteLine("Количество четных чисел в массиве: " + res);

////////////////////////////////////////////////////////////////////

// Задача 34 (*)

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

// // Метод печати массива
// void Print1DArr(int[] arr)
// {
//   Console.Write("[");
//   for(int i = 0; i < arr.Length - 1; i++)
//   {
//     Console.Write(arr[i] + ", ");
//   }
//   Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// Мтод сортировки пузырьком
void BubbleSort(int[] arr)
{
  for(int i = 0; i < arr.Length - 1; i++)
  for(int j = 0; j < arr.Length - i - 1; j++)
  {
    if(arr[j] > arr [j + 1])
    {
      int temp = arr[j];
      arr[j] = arr [j + 1];
      arr [j + 1] = temp;
    }
  }
}

// Метод сортировки подсчетом
void CountingSort(int[] arr)
{
  int max = arr.Max();
  int min = arr.Min();

  int[] count = new int[max - min + 1];
  int z = 0;

  // for(int i = 0; i < count.Length - 1; i++)
  // {
  //   count[i] = 0; 
  // } 
  for(int i = 0; i < arr.Length; i++)
  {
    count[arr[i] - min]++;
  }
  for(int i = min; i <= max; i++)
  {
    while(count[ i - min] -- > 0)
    {
      arr[z] = i;
      z++;
    }
  }
}

int[] arr = Gen1DArr(10000,100,999); 
// Print1DArr(arr);
DateTime d1 = DateTime.Now;
CountingSort(arr);
Console.WriteLine(DateTime.Now - d1);
// Print1DArr(arr);
DateTime d2 = DateTime.Now;
BubbleSort(arr);
Console.WriteLine(DateTime.Now - d2);
// Print1DArr(arr);


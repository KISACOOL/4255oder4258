﻿// Задача №32
// Напишите программу замена элементов массива: положительные
// элементы замените на соответствующие отрицательные,
// и наоборот.

//Метод генерирует 
int[] Gen1DArr(int len, int minValue, int mxValue)
{
  if(minValue > mxValue)
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
    Console.Write(arr[i] + ",");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

void InversArr(int[] arr) 
{
  for(int i = 0; )
  {

  }
}


// //Ввод длины массива
// int ReadData(string msg)
// {
//     Console.Write(msg);
//     int res = int.Parse(Console.ReadLine() ?? "0");
//     return res;
// }

// //Метод печати одномерного массива
// void Print1Darray(int []arr)
// {
//     Console.Write("[");
//     for(int i = 0; i<arr.Length-1; i++)
//     {
//         Console.Write(arr[i]+",");
//     }
//     Console.WriteLine(arr[arr.Length-1] + "]");
// }

// //Заполнение массива
// int[] Gen1DArray(int len, int top, int but)
// {
//     int[] res=new int[len];
//     for(int i=0; i<len; i++)
//     {
//         res[i]= new Random().Next(but, top+1);
//     }
//     return res;
// }
// //инвертируем массив
// int[] InvertArr(int[] arr, int len)
// {
//     for(int i=0; i<len; i++)
//     {
//         arr[i] = arr[i]*(-1);
//     }
//     return arr;
// }
// int lenArr = ReadData("Введите длину массива: ");
// int[] arr = Gen1DArray(lenArr,999,-999);
// Print1Darray(arr);
// int[] invArr = InvertArr(arr, lenArr);
// Print1Darray(invArr);

// int[] testArr = Gen1DArr(12,-9,9);
// Print1DArr(testArr);
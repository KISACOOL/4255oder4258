// Задача 38:
// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// * Отсортируйте массив методом вставки, а затем найдите
// разницу между первым и последним элементом.

//Метод генерирует  
// double[] Gen1DArr(int len, int but, int top)
// {
//   if(but > top)
//   {
//     int buf = but;
//     but = top;
//     top = buf;
//   }
//   Random rnd = new Random();
//   double[] arr = new double[len];
//   for(int i = 0; i < arr.Length; i++)
//   {
//     arr[i] = rnd.NextDouble() * (top - but) + but; 
//   }
//   return arr;
// }
// // Метод печати массива c вещественными числами
// void Print1DArr(double[] arr)
// {
//   Console.Write("[");
//   for(int i = 0; i < arr.Length - 1; i++)
//   {
//     Console.Write(arr[i] + ", ");
//   }
//   Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// // Метод вычесляющий разницу меду максимальным
// // и минимальным элементом массива.
// double DiffOfNum(double[] arr)
// {
//   double res = 0;
//   double min = arr.Min();//double.MaxValue;  
//   double max = arr.Max();//double.MinValue;  
//   for(int i = 0; i < arr.Length; i++)
//   {
//     if(min > arr[i]) arr[i] = min;
//     if(max < arr[i]) arr[i] = max;
//   }
//   res = max - min;
//   return res;
// }
// double[] arr = Gen1DArr(10,0,99); 
// Print1DArr(arr);
// double res = DiffOfNum(arr);
// Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + res);

///////////////////////////////////////////////////////////////////

// // Задача 38*

//Метод генерирует массив 
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

//  Метод сортировки массива вставками(распечатывает отсартированный массив)
void SortInsert (int[] arr)
{
  for(int i = 0; i < arr.Length; i++)
  {
    int buf = arr[i];
    int j = i - 1;
    while(j >= 0 && arr[j] > buf)
    {
      arr[j + 1] = arr[j];
      arr[j] = buf;
      j--;
    }
  }
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
      Console.Write(arr[i] + ", ");
    }
    Console.WriteLine("]");
}

int[] arr = Gen1DArr(10,0,99); 
Print1DArr(arr);
SortInsert(arr);
Console.WriteLine("Разница между последним и первым элементом массива: " + (arr[arr.Length - 1] - arr[0]));

// Я так и не придумал как убрать запятую в конце отсартированного массива.
// Задача 38:
// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// * Отсортируйте массив методом вставки, а затем найдите
// разницу между первым и последним элементом.

//Метод генерирует  
double[] Gen1DArr(int len, int but, int top)
{
  if(but > top)
  {
    int buf = but;
    but = top;
    top = buf;
  }
  Random rnd = new Random();
  double[] arr = new double[len];
  for(int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.NextDouble() * (top - but) + but; 
  }
  return arr;
}
// Метод печати массива c вещественными числами
void Print1DArr(double[] arr)
{
  Console.Write("[");
  for(int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ", ");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Метод вычесляющий разницу меду максимальным
// и минимальным элементом массива.
double DiffOfNum(double[] arr)
{
  double res = 0;
  double min = double.MaxValue;
  double max = double.MinValue;
  for(int i = 0; i < arr.Length; i++)
  {
    if(min > arr[i]) arr[i] = min;
    if(max < arr[i]) arr[i] = max;
  }
  res = max - min;
  return res;
}
double[] arr = Gen1DArr(10,0,99); 
Print1DArr(arr);
double res = DiffOfNum(arr);
Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + res);

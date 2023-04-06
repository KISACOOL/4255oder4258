// Задача №31
// Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных
// и положительных элементов массива.
// int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
} 

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

int globPosSum = 0;
int globNegSum = 0;

void NegPosSumV1(int[] arr)
{
  for(int i = 0; i < arr.Length; i++)
  {
    if(arr[i>0])
    {
      globPosSum+=arr[i];
    }
    else
    {
       globNegSum = globNegSum + arr[i];
    }
  }
}
int[] testArr = Gen1DArr(12,-9,9);
NegPosSumV1(testArr);
Console.WriteLine("Сумма положительных чисел в массиве: " + globPosSum);
Console.WriteLine("Сумма положительных чисел в массиве: " + globPosSum);
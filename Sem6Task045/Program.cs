// Задача №45
// Напишите программу, которая будет создавать
// копию заданного одномерного массива с помощью
// поэлементного копирования.


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

int[] CopyArr(int[] arr)
{
  int[] outArry = new int[arr.Length];
  for(int i = 0; i < arr.Length; i++)
  {
    outArry[i] = arr[i];
  }
  return outArry;
}

int[] arr = Gen1DArr(10, 0, 100);
Print1DArr(arr);
int [] newArr = CopyArr(arr);
Print1DArr(newArr);

int[] outArry = new int[arr.Length];
arr.CopyTo(outArry,0);
Print1DArr(outArry);
// Задача №37
// Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.
// Например:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

 int[] ConvertArr(int[] arr)
 {
  int len = (arr.Length%2 == 0)? arr.Length/2: arr.Length/2 + 1;
  int[] outArr = new int[len];
  for(int i = 0; i < len; i++)
  {
    outArr[i] = arr[i] *arr[arr.Length - 1 - i];
  }
  return outArr;
 }

int[] arr = Gen1DArr(5, 0, 10);
Print1DArr(arr);
int[] newArr = ConvertArr(arr);
Print1DArr(newArr);
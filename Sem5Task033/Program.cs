// Задача №33
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.    
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

int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

void SearchElmInArr(int elm, int[]arr)
{
  bool elmFind = false;
  for(int i = 0; i < arr.Length - 1; i++)
  {
    
    if(arr[i] == elm)
    {
      Console.WriteLine("Элемент на5 "+ i +" месте");
      elmFind = true;
    }
  }
  if(elmFind != true)
  {
    Console.WriteLine("Элемент не найден!");
  }
}

int[] arr = Gen1DArr(10,9,-9);
Print1DArr(arr);
int testElm = ReadData("Введите число для поиска: ");
SearchElmInArr(testElm, arr);
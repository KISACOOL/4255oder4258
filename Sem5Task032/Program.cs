// Задача №32
// Напишите программу замена элементов массива: положительные
// элементы замените на соответствующие отрицательные,
// и наоборот.

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
// Метод меняющий значение элементов массива плюс на минус 
void InversArr(int[] arr) 
{
  for(int i = 0; i < arr.Length - 1; i++ )
  {
    arr[i] = arr[i] * (-1);
  }
}


int[] arr = Gen1DArr(10,999,-999);
Print1DArr(arr);
InversArr(arr);
Print1DArr(arr);

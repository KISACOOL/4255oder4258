// Задача 29:
// Напишите программу, которая задаёт массив из 8
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// *Дополнительно: Написать программу которая из
// имен через запятую выберет случайное
// имя и выведет в терминал
// Игорь, Антон, Сергей -> Антон
// Подсказка: Для разбора строки
// использовать метод string.split().
// Для выбора случайного имени метод 
// Random.Next(1,<длина массива имен>+1).

// int ReadData(string msg)
// {
//   Console.WriteLine(msg);
//   int res = int.Parse(Console.ReadLine() ?? "0");
//   return res;
// }

// void Print1DArr(int[] arr)
// {
//   Console.Write("[");
//   for(int i = 0; i < arr.Length - 1; i++)
//   {
//     Console.Write(arr[i] + ",");
//   }
//   Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// int[] Gen1DArr(int len, int top, int but)
// {
//   int[] res = new int[len];
//   for(int i = 0; i < len; i++)
//   {
//     res[i] = new Random().Next(but, top + 1); 
//   }
//   return res;
// }

// int lenArr = ReadData("Введите длину массива: ");
// int top = ReadData("Введите верхнюю границу элемента массива: ");
// int but = ReadData("Введите нижнюю границу элемента массива: ");
// int[] arr = Gen1DArr(lenArr, top, but);
// Print1DArr(arr);


///////////////////////////////////////////////////////////////////////////////

// Задача 29(*)
// Метод читает данные от пользователя и преобразует их в массив. 
string[] ReadData(string names)
{
  Console.WriteLine(names);
  string[] arr = (Console.ReadLine()).Split(' ');
  return arr;
}
 //Метод печатает массив
void Print1DArr(string[] arr)
{
  Console.Write("[");
  for(int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ",");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Метод случайно выбирает одно из значений массива.  
string SelectCand(string[] arr)
{
  Random rnd = new Random();
  int index = rnd.Next(0,arr.Length);
  string res = arr[index];
  return res;
}
string[] candidates = ReadData("Введите кандидатов через пробел: ");
Print1DArr(candidates);
string runner = SelectCand(candidates);
Console.WriteLine("За пивом бежит: "+ runner);


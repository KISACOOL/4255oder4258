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

int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

void Print1DArr(int[] arr)
{
  Console.Write("[");
  for(int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ",");
  }
  Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] Gen1DArr(int len, int top, int but)
{
  int[] res = new int[len];
  for(int i = 0; i < len; i++)
  {
    res[i] = new Random().Next(but, top + 1); 
  }
  return res;
}

int lenArr = ReadData("Введите длину массива: ");
int top = ReadData("Введите верхнюю границу элемента массива: ");
int but = ReadData("Введите нижнюю границу элемента массива: ");
int[] arr = Gen1DArr(lenArr, top, but);
Print1DArr(arr);


///////////////////////////////////////////////////////////////////////////////

// // Метод читает данные от пользователя
// string ReadData(string msg)
// {
//   Console.WriteLine(msg);
//   string res = Convert.ToString(Console.ReadLine());;
//     return res;
// }


// string[] Gen1DArr(int len, int top, int but)
// {
//      string[] words = String.Split(' ');
// //   int[] res = new int[len];
// //   for(int i = 0; i < len; i++)
// //   {
// //     res[i] = new Random().Next(but, top + 1); 
// //   }
// //   return res;
// }

// string phrase = "The quick brown    fox     jumps over the lazy dog.";
// string[] words = phrase.Split(' ');

// foreach (var word in words)
// {
//     System.Console.WriteLine($"<{word}>");
// }
// string CandArr(string name)
// {
// int index = new Random().Next(arr.Length); 

// return res; 
// }
// // void Print1DArr(int[] arr)
// // {
// //   Console.Write("[");
// //   for(int i = 0; i < arr.Length - 1; i++)
// //   {
// //     Console.Write(arr[i] + ",");
// //   }
// //   Console.WriteLine(arr[arr.Length - 1] + "]");
// // }

// string[] candidates = ReadData("Введите кандидатов через пробел: ");
// // // int top = ReadData("Введите верхнюю границу элемента массива: ");
// // // int but = ReadData("Введите нижнюю границу элемента массива: ");
// // // int[] arr = Gen1DArr(lenArr, top, but);
// // CandArr(candidates);
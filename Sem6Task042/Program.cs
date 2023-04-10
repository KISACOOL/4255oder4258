// Задача №42
// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

//Метод чтения консоли
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

//Метод вывода результатов
void PrintResult(string msg, int res)
{
  Console.WriteLine(msg + res);
}

string DecToBin(int num)
{
  string res = string.Empty;
  while(num > 0)
  {
    res = res + num%2;
    num = num/2;
  }
  return res;
}

int num = ReadData("Введите число: ");
PrintResult("двоичное:" + DecToBin(num));
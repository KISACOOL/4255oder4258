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
string res = DecToBin(num);
Console.WriteLine(res);
Console.WriteLine(Convert.ToString(num,2));
Console.WriteLine(Convert.ToString(num,8));
Console.WriteLine(Convert.ToString(num,16));
// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом


int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

string LineGen(int num, int pow)
{
  string res = String.Empty;
  for(int i=1; i<=num; i++)
  {
    res += Math.Pow(i,pow) + " ";
  }
  return res;
}
int numN = ReadData("Введите число N: ");

Console.WriteLine (LineGen (num,1));
Console.WriteLine (LineGen (num,3));
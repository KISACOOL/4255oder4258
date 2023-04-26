// Задача 66:
// Pадайте значения M и N.
// Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

string RecMN(int m, int n)
{ 
  if(m <= n)
  {
  return m + RecMN(m + 1, n);
  }
  else
  {
    return string.Empty;
  }
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");

// Console.WriteLine (RecMN((m > n)?n:m, (m > n)?m:n));
// Console.WriteLine ((m > n)?RecMN(n,m):RecMN(m,n));
// Задача 67
// примает на вход число и возвращает сумму числа

int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

int SumDigRec(int num)
{
  if(num > 0)
  {
  return num%10 + SumDigRec(num / 10);
  }
  else
  {
    return 0;
  }
}

int m = ReadData("Введите m: ");
Console.WriteLine (SumDigRec(m));
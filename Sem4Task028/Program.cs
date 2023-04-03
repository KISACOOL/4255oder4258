using System.Numerics;
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

void PrintResult(string msg, int res)
{
  Console.WriteLine(msg + res); 
}


BigInteger Factor(int num)
{
  BigInteger res = 1;
  for(int i = 1, i <= num; i++);
  {
    res = res * i;
  }
  return res;
} 


//Метод чтения консоли
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

intCountPosNum(int num)
{
  int count = 0;
  while(num > 0)
  {
    int val = ReadData("Введите число: ");
    num= num - 1;
  }
  return count;
}
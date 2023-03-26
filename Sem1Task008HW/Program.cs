Console.WriteLine("Введите число");

string? numNLine = Console.ReadLine();

if (numNLine != null)
{
  int numN = int.Parse(numNLine);
  int startNum = 1;
  string resLine = string.Empty;
  int res = int.Parse(resLine);

  while (startNum <= numN)
  {
    if(res%2 == 0)
    {
      res = res + startNum + "_";
    }
    startNum++;
  }
  Console.WriteLine(res);
}

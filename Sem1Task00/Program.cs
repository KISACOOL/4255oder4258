// Считываем данные с консоли
string? inLine = Console.ReadLine();

//
if (inLine != null)
{
  //
  int inNumber = int.Parse(inLine);

  //
  int outNumber = inNumber * inNumber;
  int outStrtPow = (int)Math.Pow(inNumber,2);

  //

  //
  Console.WriteLine(outNumber);

  //
  Console.WriteLine(outStrtPow);
}


Console.WriteLine("Введите число");

string? numNLine = Console.ReadLine();

if (numNLine != null)
{
  int numN = int.Parse(numNLine);
  int startNum = numN * (-1);
  string res = string.Empty;

  while (startNum <= numN)
  {
   res = res + startNum + "_";
   startNum = startNum + 1;
  } 
  Console.WriteLine(res);
}
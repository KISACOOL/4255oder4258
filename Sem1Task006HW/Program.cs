Console.WriteLine("Введите число");

string? numLine = Console.ReadLine();

if (numLine != null)
{
  int num = int.Parse(numLine);
  
  if (num%2 == 0)
  {
    Console.Write("четное");
  }

  else
  {
    Console.Write("нечетное");
  }

}

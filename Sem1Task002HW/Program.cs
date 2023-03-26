Console.WriteLine("Введите первое число");
string? numLine1 = Console.ReadLine();

Console.WriteLine("Введите второе число");
string? numLine2 = Console.ReadLine();

if (numLine1 != null && numLine2 != null)
{
  int num1 = int.Parse(numLine1);
  int num2 = int.Parse(numLine2);
  
  if(num1 == num2)
  {
    Console.Write("the numbers are equal");
  }
  else
  {
    if(num1 > num2)
    {
      Console.Write("max ");
      Console.WriteLine(num1);
    }
      else
    {
      Console.Write("max ");
      Console.WriteLine(num2);
    }
  } 
} 
  
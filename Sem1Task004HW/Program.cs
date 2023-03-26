Console.WriteLine("Введите первое число");
string? numLine1 = Console.ReadLine();

Console.WriteLine("Введите второе число");
string? numLine2 = Console.ReadLine();

Console.WriteLine("Введите третье число");
string? numLine3 = Console.ReadLine();

if (numLine1 != null && numLine2 != null && numLine3 != null)
{
  int num1 = int.Parse(numLine1);
  int num2 = int.Parse(numLine2);
  int num3 = int.Parse(numLine3);
  
  int max = num1 ;

    if(max < num2)
    {
      max = num2 ; 
    }

    if(max < num3)
    {
      max  = num3;
    }
    
    Console.Write("max = ");
    Console.WriteLine(max);
}

  

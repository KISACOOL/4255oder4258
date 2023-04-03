// Задача №24
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

void PrintResult(string msg, int res)
{
  
}

long SumSimpel(int numA)
{
  long sum = 0;
  for(int i = 1; i <=numA; i++)
  sum+=i;
}
return sum;

int numberA =  ReadData("Введите число А: ");
long res1 = SumSimple(numberA);
PrintResult("Сумма")
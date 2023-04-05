// Задача №26
// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.

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

int CountDigit(int num)
{
  int res = 0;
  while(num > 0)
  {
    res = res + 1;
    num = num/10;
  } 
  // int res = (int)Math.Log10(num) + 1;
  return res;
}


int numberA = ReadData("Введите число: ");
int res1 = CountDigit(numberA);
PrintResult("Число состоит из ", res1);

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
  int res = (int)Math.Log10(number + 1);
}
return res;

int numberA = ReadData("Введите число: ");


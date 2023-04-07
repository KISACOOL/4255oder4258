// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

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
// Метод складывающий цифры в числе
int CountSumDigit(int num)
{
  int res = 0;
  while(num > 0)
  {
    res = res + num%10;
    num = num/10;
  } 
  return res;
}
int numberA = ReadData("Введите число: ");
int res1 = CountSumDigit(numberA);
PrintResult("Сумма цифр в числе: ", res1);

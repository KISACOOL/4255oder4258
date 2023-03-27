// Задача №14
// Напишите программу, которая принимает на вход число и проверяет, кратно
// ли оно одновременно 7 и 23.


Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()??"0");

bool res = ((num1%7 == 0) && (num1%23 == 0));

if (res)
{
  Console.WriteLine("кратно");
}
else
{
  Console.WriteLine("не кратно");
}
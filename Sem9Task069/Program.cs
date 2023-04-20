// Задача 69 
// Напишите прграмму, которая будет принимать
// 2 числа А и В возыедите А в степень В с помощью рекурсии

int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}
// long RecPow(int a, int b)
// {
//   if(b > 0)
//   {
//     return(a * RecPow(a,b - 1));
//   }
//   else
//   {
//     return 1;
//   }
// }

long MyRecPow(int a, int b)
{
  if(b == 2)
  {
    return 4;
  }
  else
  {
    return MyRecPow(a,b/2) * MyRecPow(a,b/2);
  }
}
int a = ReadData("Введите a: ");
int b = ReadData("Введите b: ");
Console.WriteLine (MyRecPow(a, b));
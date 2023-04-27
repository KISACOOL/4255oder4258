// Задача 68:
// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

int FunctionAkkerman(int m, int n)
{
  if(m == 0) return n + 1;
  else if(n == 0) return FunctionAkkerman(m - 1,1);
  else return FunctionAkkerman(m - 1,FunctionAkkerman(m,n - 1));
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
Console.WriteLine(FunctionAkkerman(m,n));
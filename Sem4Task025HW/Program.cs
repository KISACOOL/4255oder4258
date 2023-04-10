// Задача №25
// Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень

// //Метод чтения консоли
// int ReadData(string msg)
// {
//   Console.WriteLine(msg);
//   int res = int.Parse(Console.ReadLine() ?? "0");
//   return res;
// }

// //Метод вывода результатов
// void PrintResult(string msg, long res)
// {
//   Console.WriteLine(msg + res);
// }

// //Метод возведения в стпень 
// long MyPow(int a, int b)
// {
//   long res = 1;
//   while(b > 0)
//   {
//     res = res * a;
//     b = b - 1; 
//   }
//   return res;
// }

// int a = ReadData("Введите число А: ");
// int b = ReadData("Введите число В: ");
// long numPow = MyPow(a,b);
// PrintResult("Число А в степени В равно: ", numPow);

//////////////////////////////////////////////////////////////////
// Задача №25* Калькулятор

//Метод ввода
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}
//Метод ввода оператора
int ReadDataOper (string msg)
{
  Console.WriteLine(msg);
  char res = Convert.ToChar(Console.ReadLine());
  return res;
}
//Метод сложения
long Sum(int a, int b)
{
  long res = a + b;
  return res;
}
//Метод вычетания
long Sub(int a, int b)
{
  long res = a - b;
  return res;
}
//Метод деления
double Div(int a, int b)
{
  double res = a / b;
  return res;
}
//Метод умножения
long Mult(int a, int b)
{
  long res = a * b;
  return res;
}

//Метод возведения в стпень 
long MyPow(int a, int b)
{
  long res = 1;
  while(b > 0)
  {
    res = res * a;
    b = b - 1; 
  }
  return res;
}
int a = ReadData("Введите число А: ");
int oper = ReadDataOper("Введите знак операции: ");
int b = ReadData("Введите число В: ");
if (oper == '+' ) Console.WriteLine(Sum(a,b));
if (oper == '-' ) Console.WriteLine(Sub(a,b));
if (oper == '/' ) Console.WriteLine(Div(a,b));
if (oper == '*' ) Console.WriteLine(Mult(a,b));
if (oper == '^') Console.WriteLine(MyPow(a,b));
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

// ///////////////////////////////////////////////////////////////

// // Это метод Арада учимся работать в команде)))

// int ReadNum1(string message)
// {
// Console.WriteLine(message);
// int num1 = int.Parse(Console.ReadLine() ?? "0");
// return num1;
// }

// // Вот это вообще зачем нужно?

// // int ReadNum2(string message)
// // {
// // Console.WriteLine(message);
// // int num2 = int.Parse(Console.ReadLine() ?? "0");
// // return num2;
// // }

// void PrintResult(string message, int res) // я бы поменял на long res
// {
// Console.WriteLine(message+res);
// }

// int CountDigit(int Number1, int Number2)
// {
// int res2 = 1;    // long
// int result = 1;  // long
// while(result<=Number2)
// {
// result=result +1;
// res2 = Number1*res2;

// }

// return res2 ;
// }
// int numberA = ReadNum1("put number 1: ");
// int numberB = ReadNum1("put number 2: ");
// int res2 = CountDigit (numberA, numberB); //long
// PrintResult ("CountDigit: ",(int)res2);  // (int) нафиг

//////////////////////////////////////////////////////////////

// Задача №25* Калькулятор

int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

int ReadDataOper (string msg)
{
  Console.WriteLine(msg);
  char res = Convert.ToChar(Console.ReadLine());
  return res;
}

long Sum(int a, int b)
{
  long res = a + b;
  return res;
}

long Sub(int a, int b)
{
  long res = a - b;
  return res;
}

double Div(int a, int b)
{
  double res = a / b;
  return res;
}

long Mult(int a, int b)
{
  long res = a * b;
  return res;
}

int a = ReadData("Введите число А: ");
int oper = ReadDataOper("Введите знак операции: ");
int b = ReadData("Введите число В: ");
if (oper == '+' ) Console.WriteLine(Sum(a,b));
if (oper == '-' ) Console.WriteLine(Sub(a,b));
if (oper == '/' ) Console.WriteLine(Div(a,b));
if (oper == '*' ) Console.WriteLine(Mult(a,b));
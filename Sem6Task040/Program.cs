
// Задача №40
// Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами
// такой длины.

//Метод чтения консоли
int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

bool TrianTest(int a, int b, int c)
{
  bool res = falce;
  if((a<=b+c) && (b<=a+c) && (c<=a+b))
  {
    Console.WriteLine("треугольник существует");
  }
  else
  {
    Console.WriteLine("треугольник не существует"); 
  }
}

int numberA =  ReadData("Введите длинну стороны А: ");
int numberB =  ReadData("Введите длинну стороны B: ");
int numberC =  ReadData("Введите длинну стороны C: ");
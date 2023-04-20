// Задача 63
// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

void LineGenRec(int numN)
{
  Console.Write(numN+ " ");
  if(numN <= 1)
  {

  }
  else
  {
    LineGenRec(numN - 1);
  }
}

int num = ReadData();
// Считываем данные с консоли
string? inLine = Console.ReadLine();

// Проверим чтобы данные не были пустыми
if (inLine != null)
{
  // Парсим введенное число
  int inNumber = int.Parse(inLine);

  // Находим квадрат числа
  int outNumber = inNumber * inNumber;
  int outStrtPow = (int)Math.Pow(inNumber,2);

  // Выводим данные в консоль
  Console.WriteLine(outNumber);

  // 
  Console.WriteLine(outStrtPow);
}


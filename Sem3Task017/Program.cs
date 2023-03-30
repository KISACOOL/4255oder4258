// Задача №17
// Напишите программу, которая принимает на вход координаты
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер 
// четверти плоскости, в которой находится эта точка.

// Метод читает данные от пользователя

int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}

// int coordX = ReadData("Введите координату x: ");
// int coordY = ReadData("Введите координату y: ");

void PrintQuterTest(int x, int y)
{
  if (x > 0 && y > 0) Console.WriteLine("точка в 1 четверти");
  if (x > 0 && y < 0) Console.WriteLine("точка в 2 четверти");
  if (x < 0 && y > 0) Console.WriteLine("точка в 3 четверти");
  if (x < 0 && y < 0) Console.WriteLine("точка в 4 четверти");
}

int coordX = ReadData("Введите координату X: ");
int coordY = ReadData("Введите координату Y: ");
PrintQuterTest(coordX, coordY);

// Здесь какаято ошибка!!!!!
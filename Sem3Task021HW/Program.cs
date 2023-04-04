// Задача 21
// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadData(string msg)
{
  Console.WriteLine(msg);
  int res = int.Parse(Console.ReadLine() ?? "0");
  return res;
}
// Метод находит растояние между точками 
double CalcLen3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
   return Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
}
int x1 = ReadData("Введите координату x точки A: ");
int y1 = ReadData("Введите координату y точки A: ");
int z1 = ReadData("Введите координату z точки A: ");
int x2 = ReadData("Введите координату x точки B: ");
int y2 = ReadData("Введите координату y точки B: ");
int z2 = ReadData("Введите координату z точки B: ");
Console.WriteLine("Растояние между точками A и B: " + CalcLen3D(x1, y1, z1, x2, y2, z2));

// В начале я допустил ошибку в строке 24:
// Console.WriteLine("Растояние между точками A и B: " + CalcLen3D(x1, y1, x2, y2, z1, z2));
// Но почему он стал сщитать по другому непонял и как то есть КАК, что получается 9,43
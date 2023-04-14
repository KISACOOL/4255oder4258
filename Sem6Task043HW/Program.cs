// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых

double ReadData(string msg)
{
  Console.WriteLine(msg);
  double res = double.Parse(Console.ReadLine() ?? "0");
  return res;
}

//Метод вычисляющий точки пересечения. 
void FindIntersectionPoint(double b1, double k1, double b2, double k2)
{
  double x = -(b1 - b2)/(k1 - k2);
  double y = k1 * x + b1;
  Console.WriteLine("Точка пересечения двух прямых: " + (x,y));
}

double b1 = ReadData("Введите точу b1: ");
double k1 = ReadData("Введите точу k1: ");
double b2 = ReadData("Введите точу b2: ");
double k2 = ReadData("Введите точу k2: ");
FindIntersectionPoint(b1, k1, b2, k2);


// // Задача 43*

// double K1 = ReadData("Введите номер K1: ");
// double B1 = ReadData("Введите номер B1: ");
// double K2 = ReadData("Введите номер K2: ");
// double B2 = ReadData("Введите номер B2: ");
// double K3 = ReadData("Введите номер K3: ");
// double B3 = ReadData("Введите номер B3: ");

// //Поиск координат пересечения.
// (double x, double y) pointA = CrossPoint(K1, B1, K2, B2);
// (double x, double y) pointB = CrossPoint(K2, B2, K3, B3);
// (double x, double y) pointC = CrossPoint(K3, B3, K1, B1);

// double X1 = pointA.x;
// double Y1 = pointA.y;
// double X2 = pointB.x;
// double Y2 = pointB.x;
// double X3 = pointC.x;
// double Y3 = pointC.x;

// PrintData($"Точки пересечения 3-х линий: X1 = {X1}; Y1 = {Y1}; X2 = {X2}; Y2 = {Y2}; X3 = {X3}; Y3 = {Y3}");

// double sideA = TriangleSide(X1, Y1, X2, Y2);
// double sideB = TriangleSide(X2, Y2, X3, Y3);
// double sideC = TriangleSide(X3, Y3, X1, Y1);

// PrintData($"Длинна сторон треугольника: A = {sideA}; B = {sideB}; C = {sideC}");
// PrintData($"Площадь треугольника: S = {SquareTriangle(sideA, sideB, sideC)}");

// //метод запрашивает и ситывает данные с консоли
// double ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return double.Parse(Console.ReadLine() ?? "0");
// }

// //метод вывода данных
// void PrintData(string msg)
// {
//   Console.WriteLine(msg);
// }

// // Комплексный метод
// (double x, double y) CrossPoint(double k1, double b1, double k2, double b2)
// {
//   double coorX1 = (b2 - b1) / (k1 - k2);
//   double coorY1 = (k1 * b2 - k2 * b1) / (k1 - k2);
//   return (coorX1, coorY1);
// } 

// // Находим стороны треугольника.
// double TriangleSide(double x1, double y1,double x2, double y2)
// {
//   double res = Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2));
//   return res;
// }
// // Находит площадь треугольника через полумериметр(p = (a + b + c) / 2) сторон и длинны сторон
// double SquareTriangle(double a, double b, double c)
// {
//   double squareT = Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c));
//   return squareT;
// }
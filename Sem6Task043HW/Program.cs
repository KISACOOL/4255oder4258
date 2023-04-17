// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых

// double ReadData(string msg)
// {
//   Console.WriteLine(msg);
//   double res = double.Parse(Console.ReadLine() ?? "0");
//   return res;
// }

// //Метод вычисляющий точки пересечения. 
// void FindIntersectionPoint(double b1, double k1, double b2, double k2)
// {
//   double x = -(b1 - b2)/(k1 - k2);
//   double y = k1 * x + b1;
//   Console.WriteLine("Точка пересечения двух прямых: " + (x,y));
// }

// double b1 = ReadData("Введите точу b1: ");
// double k1 = ReadData("Введите точу k1: ");
// double b2 = ReadData("Введите точу b2: ");
// double k2 = ReadData("Введите точу k2: ");
// FindIntersectionPoint(b1, k1, b2, k2);


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

const int X1 = 0;
const int Y1 = 1;
const int X2 = 0;
const int Y2 = 1;
const int X3 = 0;
const int Y3 = 1;
const int coef = 0;
const int con = 1;
const int Line1 = 1;
const int Line2 = 2;
const int Line3 = 3;

//Вызов метода для записи чисел
double[] LineData1 = LineData(Line1);
double[] LineData2 = LineData(Line2);
double[] LineData3 = LineData(Line3);

if (IntersectLines(LineData1, LineData2,LineData3))
{
    double[] coord1 = FindCoords1(LineData1, LineData2);
    Console.WriteLine($"Точка пересечений уравнений Y = {LineData1[coef]}*X+{LineData1[con]} /n Y= {LineData2[coef]}*X+{LineData2[con]}");
    Console.WriteLine($"Имеет координаты ({coord1[X1]}, {coord1[Y1]})");
    double[] coord2 = FindCoords2(LineData2, LineData3);
    Console.WriteLine($"Точка пересечений уравнений Y = {LineData2[coef]}*X+{LineData2[con]} /n Y= {LineData3[coef]}*X+{LineData3[con]}");
    Console.WriteLine($"Имеет координаты ({coord2[X2]}, {coord2[Y2]})");
    double[] coord3 = FindCoords3(LineData1, LineData3);
    Console.WriteLine($"Точка пересечений уравнений Y = {LineData1[coef]}*X+{LineData1[con]} /n Y= {LineData3[coef]}*X+{LineData3[con]}");
    Console.WriteLine($"Имеет координаты ({coord3[X3]}, {coord3[Y3]})");
    Console.WriteLine($"Площадь треугольника = {(1/2) * (Math.Abs((coord2[X2] - coord1[X1])*(coord3[Y3]-coord3[Y1]) - (coord3[X3] - coord1[X1])*(coord2[Y2]-coord1[Y1])))}");
}

//Ввод числа
double ReadMSG(string msg)
{
    Console.Write(msg);
    string row = Console.ReadLine();
    double res = Convert.ToDouble(row);
    return res;
}

//Данные в пямую
double[] LineData(double NumOfLines)
{
    double[] LineData = new double[3];
    LineData[coef] = ReadMSG($"Введите k для {NumOfLines} прямой: ");
    LineData[con] = ReadMSG($"Введите b для {NumOfLines} прямой: ");
    return LineData;
}

//Поиск координат
double[] FindCoords1(double[] LineData1, double[] LineData2)
{
    double[] coord1 = new double[2];
    coord1[X1] = (LineData1[con] - LineData2[con]) / (LineData2[coef] - LineData1[coef]);
    coord1[Y1] = LineData1[coef] * coord1[X1] + LineData1[con];
    return coord1;
}

double[] FindCoords2(double[] LineData2, double[] LineData3)
{
    double[] coord2 = new double[2];
    coord2[X2] = (LineData2[con] - LineData3[con]) / (LineData3[coef] - LineData2[coef]);
    coord2[Y2] = LineData1[coef] * coord2[X2] + LineData1[con];
    return coord2;
}

double[] FindCoords3(double[] LineData1, double[] LineData3)
{
    double[] coord3 = new double[2];
    coord3[X3] = (LineData3[con] - LineData1[con]) / (LineData1[coef] - LineData3[coef]);
    coord3[Y3] = LineData1[coef] * coord3[X3] + LineData1[con];
    return coord3;
}
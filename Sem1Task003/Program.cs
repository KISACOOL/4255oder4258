//Console.WriteLine("Введите день недели");

//string? dayLine = Console.ReadLine();

//if (dayLine != null)
//{
//  string[] dayWeek = new string[7];
  
//  dayWeek[0] = "понедельник";
//  dayWeek[1] = "вторник";
//  dayWeek[2] = "среда";
//  dayWeek[3] = "четверг";
// dayWeek[4] = "пятница";
//  dayWeek[5] = "суббота";
//  dayWeek[6] = "воскресенье";
  
//  int day = int.Parse(dayLine);
  
//  Console.WriteLine(dayWeek[day - 1]);
//} 
   


Console.WriteLine("Введите день недели");
//считываем данные с консоли
string? inputLine = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if (inputLine != null)
{
  //Парсим введенное число
  int inputNumber = int.Parse(inputLine);

  string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber));
  //Выводим данные в консоль
  Console.WriteLine(outDayOfWeek);
}


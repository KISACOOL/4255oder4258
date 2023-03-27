//Задача №9
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числ


System.Random numSintezator = new System.Random();

// вариант 1

int rndNum = numSintezator.Next(10,100);

Console.WriteLine(rndNum);

short firstNum = (short) (rndNum/10);
short secondNum = (short) (rndNum%10);

if (firstNum > secondNum)
{
  Console.WriteLine("первое число " + firstNum + "второго" + secondNum);
}
else
{
  Console.WriteLine(secondNum);
}

// вариант 2


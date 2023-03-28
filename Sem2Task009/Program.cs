//Задача №9
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числ


System.Random numSintezator = new System.Random();

// вариант 1

int rndNum = numSintezator.Next(10,100);

Console.WriteLine(rndNum);

// можно использовать тип размера short но он меньше int (использование short грамотнее так как использует меньший обьем оперативной памяти)
// short firstNum = (short) (rndNum/10);
// short secondNum = (short) (rndNum%10);


int firstNum = rndNum/10;
int secondNum = rndNum%10;

if (firstNum > secondNum)
{
  Console.WriteLine("первое число " + firstNum + " больше второго " + secondNum);
}
else
{
  Console.WriteLine("второе число " + secondNum + " больше первого " + firstNum);
}

// вариант 2

char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);

firstNum = (int) (digits[0]) - 48; 
secondNum = (int) (digits[1]) - 48;

// <переменная> = (условие)? <значение 1>: <значение 2>; 

// if (условие)
// {
//   <переменная> = <значение 1>;
// }
// else
// {
//   <переменная> = <значение 2>;
// }

int res = (firstNum > secondNum)? firstNum:secondNum;
Console.WriteLine(res);





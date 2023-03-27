// Задача №11
// Напишите программу, которая выводит случайное трёхзначное
// число и удаляет вторую цифру этого числа.

// int rndNum = new Random().Next(100,1000);
// Console.WriteLine(rndNum);
// int firstNum = rndNum/100;
// int lastNum = rndNum%10;

// int newNum = firstNum * 10 + lastNum;

// Console.WriteLine(newNum);


System.Random numSintezator = new System.Random();

char[] digits = numSintezator.Next(100, 1000).ToString().ToCharArray();
Console.WriteLine(digits);
char[] res = {digits[0], digits[2]};
Console.WriteLine(res);
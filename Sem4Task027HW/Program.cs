Console.Clear();

Console.Write("Введите число : "); 
int num = Convert.ToInt32(Console.ReadLine());

void PrintRes(string msg, int sum) // Метод ввывода 
{
    Console.WriteLine(msg + sum);
}

int Sum(int num)// Метод  подсчета суммы числа 
{

    int lenght = Convert.ToString(num).Length;
    int progress = 0;
    int res = 0;

    for (int i = 0; i < lenght; i++)
    {
        progress = num - num % 10;
        res = res + (num - progress);
        num = num / 10;
    }
    return res;
}

int sum = Sum(num);
PrintRes("Сумма числа: " ,  sum); // Ввывод числа
странной конечно, делаю через длину строки
Сергей Чубарев 19:58
я делал через подсчёт цифр в числе, потом через цикл по количеству цифр складывал их
//Метод суммирования цифр
long SummNum(long CountN, long num)
{
    long res = 0;
    for(int i=0; i<=CountN; i++)
    {
        res += num%10;
        num=num/10;
    }
    return res;
}

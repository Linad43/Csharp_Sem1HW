/*
Задача 24: Напишите программу,
которая принимает на вход число (А)
и выдаёт сумму чисел от 1 до А.
*/
/*
Console.WriteLine("Введите число:");
int GetSumNum(int num)
{
    int SumNum = 0;
    int i=num;
    while (i>0)
    {
        SumNum = SumNum + i;
        i--;
    }
    return SumNum;
}
Console.WriteLine(GetSumNum(Convert.ToInt32(Console.ReadLine())));
*/
/*
Задача 26: Напишите программу,
которая принимает на вход число
и выдаёт количество цифр в числе.
*/
/*
Console.WriteLine("Введите число:");
int num1 = Convert.ToInt32(Console.ReadLine());
int GetNumCount()
{
    int i=0;
    while (num1!=0)
    {
        num1 /= 10;
        i++;
    }
    return i;
}
Console.WriteLine(GetNumCount());
*/


/*
Console.WriteLine("Введите число:");
int num3 = Convert.ToInt32(Console.ReadLine());
int GetPrNum()
{
    int PrNum = 1;
    int i=num3;
    while (i>0)
    {
        PrNum *= i;
        i--;
    }
    return PrNum;
}
Console.WriteLine(GetPrNum());
*/

Console.WriteLine("Новая программа");
int[] num3 = new int[8];
int i=0;
while (i < 8)
{
    num3[i] = new Random().Next(0,2);
    Console.Write($"{num3[i]} ");
    i++;
}

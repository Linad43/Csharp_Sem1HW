/*
Задача 63: Задайте значение N.
Напишите программу,
которая выведет все натуральные числа
в промежутке от 1 до N.
*/
/*
int ReadInt(string text)
{
    System.Console.WriteLine($"Введите число {text}:");
    return Convert.ToInt32(Console.ReadLine());
}
void printNum(int N, int M)
{
    if (M < N)
    {
        return;
    }
    printNum(N, M - 1);
    Console.Write($"{M} ");
}
int N = ReadInt("N");
int M = ReadInt("M");
if (N > M)
{
    printNum(N, M);
}
else
{
    printNum(M, N);
}
*/
/*
int n = ReadInt("Введите число N: ");

System.Console.WriteLine(SumNumbers(n));

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int n)
{
    if (n == 0)
    {
        return 0;
    }
    return n % 10 + SumNumbers(n / 10);
}
*/
/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/
int a = ReadInt("Введите число A: ");
int b = ReadInt("Введите число B: ");
System.Console.WriteLine(pow(a,b));

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int pow(int a, int b)
{
    if (b == 1)
    {
        return a;
    }
    return a * pow(a, b - 1);
}
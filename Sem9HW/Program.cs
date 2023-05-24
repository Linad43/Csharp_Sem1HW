/*
Задача 64: Задайте значение N.
Напишите программу,
которая выведет все натуральные числа
в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void Zad64(int N)
{
    if (N <= 1)
    {
        Console.Write($"{N}\n");
        return;
    }
    Console.Write($"{N}, ");
    Zad64(N - 1);
}
/*
Задача 66: Задайте значения M и N.
Напишите программу,
которая найдёт сумму натуральных элементов
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/
int Zad66(int M, int N)
{
    if (M < N)
    {
        return 0;
    }
    return M + Zad66(M - 1, N);
}
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int Zad68(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0)
    {
        return Zad68(M - 1, 1);
    }
    else
    {
        return Zad68(M - 1, Zad68(M, N - 1));
    }
}


bool flag = true;
while (flag)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Выберите задачу:");
    System.Console.WriteLine("1. Задача 64");
    System.Console.WriteLine("2. Задача 66");
    System.Console.WriteLine("3. Задача 68");
    System.Console.WriteLine("0. Выход");
    System.Console.WriteLine();
    int choice = ReadInt("");

    switch (choice)
    {
        case 1:
        {
            int N = ReadInt("Введите N: ");
            Zad64(N);
            break;
        }
        case 2:
        {
            int M = ReadInt("Введите M: ");
            int N = ReadInt("Введите N: ");
            if (M > N)
            {
                System.Console.WriteLine($"Сумма чисел в промежутке [{N},{M}] = {Zad66(M, N)}");
            }
            else if (N > M)
            {
                System.Console.WriteLine($"Сумма чисел в промежутке [{M},{N}] = {Zad66(N, M)}");
            }
            else
            {
                System.Console.WriteLine($"Сумма чисел в промежутке [{M},{N}] = {M}");
            }
            break;
        }
        case 3:
        {
            int M = ReadInt("Введите M: ");
            int N = ReadInt("Введите N: ");
            System.Console.WriteLine($"A[{M},{N}] = {Zad68(M, N)}");
            break;
        }
        default:
            flag = false;
            break;
    }
}
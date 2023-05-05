/*
Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
*/

Console.WriteLine("Введите размер двумерного массива m x n:");
Console.Write("m=");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("n=");
int N = Convert.ToInt32(Console.ReadLine());
double[,] mass=new double[M,N];
for(int i=0;i<M;i++)
{
    for(int j=0;j<N;j++)
    {
        mass[i,j] = new Random().Next(0,2000);
        mass[i,j]-=1000;
        mass[i,j]/=100;
        Console.Write($"{mass[i,j]} ");
    }
    Console.Write("\n");
}

/*
Задача 50. Напишите программу,
которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание,
что такого элемента нет.
*/

Console.Write("Какой элемент вывести из вышеописанного массива? ");
int num = Convert.ToInt32(Console.ReadLine());
if (num<=M*N && num>0)
{
    int i=0; 
    int j=0;
    while (num>N)
    {
        num-=N;
        i++;
    }
    j=num-1;
    Console.WriteLine($"{i*N+j+1} -> {mass[i,j]}");
}
else
{
    Console.WriteLine($"{num} -> нет такого элемента");
}

/*
Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
*/

Console.WriteLine("Теперь найдем среднее арифметическое в каждом столбце");
double[] sred_mass = new double[N];
for(int i=0;i<M;i++)
{
    for(int j=0;j<N;j++)
    {
        sred_mass[j]+=mass[i,j];
    }    
}
for(int i=0;i<N;i++)
{
    sred_mass[i]/=M;
    Console.Write($"{Math.Round(sred_mass[i],4)} ");
}
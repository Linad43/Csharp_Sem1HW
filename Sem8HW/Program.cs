/*
Задача 54: Задайте двумерный массив.
Напишите программу,
которая упорядочит по убыванию элементы каждой строки
двумерного массива.
*/
/*
Console.WriteLine("Введите размер двумерного массива m x n:");
Console.Write("m=");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("n=");
int N = Convert.ToInt32(Console.ReadLine());
double[,] mass=new double[M,N];
Console.Write("Заданный массив\n");
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
Console.Write("Упорядоченный массив\n");
//упорядочение по убыванию
{
    double buff;
    for(int i=0;i<M;i++)
    {
        for(int j=0;j<N;j++)
        {
            for(int k=0;k<N-j-1;k++)
            {
                if(mass[i,k]<mass[i,k+1])
                {
                    buff=mass[i,k];
                    mass[i,k]=mass[i,k+1];
                    mass[i,k+1]=buff;
                }
            }
        }
    }
}
for(int i=0;i<M;i++)
{
    for(int j=0;j<N;j++)
    {
        Console.Write($"{mass[i,j]} ");
    }
    Console.Write("\n");
}
*/
/*
Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу,
которая будет находить строку
с наименьшей суммой элементов.
*/
//Сразу найдем наименьшую сумму элементов построчно
/*
double[] sum = new double[M];
double min_sum=0;
int min_num_sum=0;
for(int i=0;i<M;i++)
{
    for(int j=0;j<N;j++)
    {
        sum[i]+=mass[i,j];
    }
    if (i==0)
    {
        min_sum=sum[i];
        min_num_sum=i;
    }
    if (sum[i]<min_sum)
    {
        min_sum=sum[i];
        min_num_sum=i;
    }
}
Console.Write($"Строка с наименьшой суммой: {min_num_sum+1}\n");
Console.Write($"Наименьшая сумма: {min_sum}\n");
*/
/*
Задача 58: Задайте две матрицы.
Напишите программу,
которая будет находить произведение двух матриц.
*/
/*
Console.WriteLine("Перемножение матриц A[m_1,n_1] и B[m_2,n_2]");
Console.WriteLine("Так как при перемножении матриц должно выполняться n_1=m_2");
Console.WriteLine("Выполним замену на k");
Console.WriteLine("Введите размеры массивов A[m_1,k] и B[k,n_2]:");
Console.Write("m_1=");
M = Convert.ToInt32(Console.ReadLine());
Console.Write("k=");
int K = Convert.ToInt32(Console.ReadLine());
Console.Write("n_2=");
N = Convert.ToInt32(Console.ReadLine());
double[,] mass1=new double[M,K];
double[,] mass2=new double[K,N];
double[,] pr_mass=new double[M,N];
for(int i=0;i<M;i++)
{
    for(int j=0;j<K;j++)
    {
        mass1[i,j] = new Random().Next(0,2000);
        mass1[i,j]-=1000;
        mass1[i,j]/=100;
        Console.Write($"{mass1[i,j]} ");
    }
    Console.Write("\n");
}
Console.Write("\n");
for(int i=0;i<K;i++)
{
    for(int j=0;j<N;j++)
    {
        mass2[i,j] = new Random().Next(0,2000);
        mass2[i,j]-=1000;
        mass2[i,j]/=100;
        Console.Write($"{mass2[i,j]} ");
    }
    Console.Write("\n");
}
Console.Write("\n");
for(int i=0;i<M;i++)
{
    for(int j=0;j<N;j++)
    {
        for(int k=0;k<K;k++)
        {
            pr_mass[i,j]+=mass1[i,k]*mass2[k,j];
        }
        Console.Write($"{Math.Round(pr_mass[i,j],4)} ");
    }
    Console.Write("\n");
}
*/
/*
Задача 60. ...Сформируйте трёхмерный массив
из неповторяющихся двузначных чисел.
Напишите программу,
которая будет построчно выводить массив,
добавляя индексы каждого элемента.
*/
/*
Console.WriteLine("Введите размер трехмерного массива A[m,n,k]:");
Console.Write("m=");
M = Convert.ToInt32(Console.ReadLine());
Console.Write("n=");
N = Convert.ToInt32(Console.ReadLine());
Console.Write("k=");
K = Convert.ToInt32(Console.ReadLine());
double[,,] mass3=new double[M,N,K];
for(int i=0;i<M;i++)
{
    for(int j=0;j<N;j++)
    {
        for (int k=0;k<K;k++)
        {
            mass3[i,j,k] = new Random().Next(200)-100;
            Console.Write($"{mass3[i,j,k]}({i},{j},{k}) ");
        }
        Console.Write("\n");
    }
    Console.Write("\n");
}
*/
/*
Задача 62. Напишите программу,
которая заполнит спирально массив 4 на 4.
*/
int M=4, N=4;
double[,] mass4=new double[M,N];
int k=0, i=0, j=0;
int vec=0;//0 - право, 1 - вниз, 2 - лево, 3 - верх
int len=0;
bool flag=true;
while(flag)
{
    if(vec==0)
    {
        while(j<N-len)
        {
            mass4[i,j]=k;
            j++;
            k++;
        }
        j--;
        i++;
    }
    else if(vec==1)
    {
        while(i<M-len)
        {
            mass4[i,j]=k;
            i++;
            k++;
        }
        i--;
        j--;
    }
    else if(vec==2)
    {
        while(j>=0+len)
        {
            mass4[i,j]=k;
            j--;
            k++;
        }
        j++;
        i--;
    }
    else if(vec==3)
    {
        len++;
        while(i>=0+len)
        {
            mass4[i,j]=k;
            i--;
            k++;
        }
        i++;
        j++;
    }
    vec++;
    if(vec==4)
    {
        vec=0;
    }
    if(mass4[i,j]!=0)
    {
        flag=false;
    }
}
for(i=0;i<M;i++)
{
    for(j=0;j<N;j++)
    {
        Console.Write($"{mass4[i,j]} ");
    }
    Console.Write("\n");
}
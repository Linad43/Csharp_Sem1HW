/*
Задача 25: Напишите цикл,
который принимает на вход
два числа (A и B) и
возводит число A в натуральную степень B.
*/
/*
Console.WriteLine("Введите основание степени:");
int osn=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень:");
int step=Convert.ToInt32(Console.ReadLine());
int GetStepNum(int A, int B)
{
    int StepNum=1;
    for(int i=0;i<B;i++)
    {
        StepNum=StepNum * A;
    }
    return StepNum;
}
Console.WriteLine(GetStepNum(osn, step));
*/
/*
Задача 27: Напишите программу,
которая принимает на вход число
и выдаёт сумму цифр в числе.
*/
/*
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int GetSumNum(int A)
{
    int SumNum=0;
    while(A!=0)
    {
        SumNum=SumNum + A%10;
        A=A/10;        
    }
    return SumNum;
}
Console.WriteLine(GetSumNum(num));

*/

/*
Задача 29: Напишите программу,
которая задаёт массив из 8 элементов
и выводит их на экран.
*/

Console.WriteLine("Введите массив");
int N=8;
int[] num3 = new int[N];
int[]ReadArr(int N)
{   
    int[] Arr = new int[N];
    for (int i=0; i < Arr.Length;i++)
    {
        Console.Write($"a[{i}] = ");
        Arr[i] = Convert.ToInt32(Console.ReadLine());
        //Arr[i] = new Random().Next(-999,1000);
    }
    return Arr;
}
void WriteArr(int[] Arr)
{
    Console.WriteLine("Введен массив:");
    for (int i=0;i<Arr.Length;i++)
    {
        Console.Write($"{Arr[i]} ");
    }
}
num3=ReadArr(N);
WriteArr(num3);
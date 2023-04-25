/*
Задача 34: Задайте массив
заполненный случайными положительными трёхзначными
числами. Напишите программу,
которая покажет количество чётных чисел в массиве.
*/

int length=new Random().Next(10,100);

int[] NewArr = new int[length];
int chet=0;
Console.WriteLine("Введенный массив:");

for(int i=0;i<NewArr.Length;i++)
{
    NewArr[i] = new Random().Next(100,1000);
    Console.Write($"{NewArr[i]} ");
    if(NewArr[i]%2==0)
    {
        chet++;
    }
}

Console.WriteLine("\nКол-во четных "+chet);
/*
Задача 36: Задайте одномерный массив,
заполненный случайными числами.
Найдите сумму элементов,
стоящих на нечётных позициях.
*/


int length1=new Random().Next(10,100);

int[] NewArr1 = new int[length1];
int Sum=0;
Console.WriteLine("Введенный массив:");

for(int i=0;i<NewArr1.Length;i++)
{
    NewArr1[i] = new Random().Next(100,1000);
    Console.Write($"{NewArr1[i]} ");
    if(i%2==0)
    {
        Sum+=NewArr1[i];
    }
}
Console.WriteLine("\nСумма нечетных позиций:"+Sum);

/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
*/

int length2=new Random().Next(10,100);

float[] NewArr2 = new float[length1];
Console.WriteLine("Введенный массив:");

for(int i=0;i<NewArr2.Length;i++)
{
    NewArr2[i] = new Random().Next(0,10000);
    NewArr2[i]/=100;
    Console.Write($"{NewArr2[i]} ");
}
float min=NewArr2[0], max=NewArr2[0];
for(int i=1;i<NewArr2.Length;i++)
{
    if (NewArr2[i]>max)
    {
        max=NewArr2[i];
    }
    if (NewArr2[i]<min)
    {
        min=NewArr2[i];
    }
}
Console.WriteLine("\nMax:"+max+" Min:"+min);
Console.WriteLine("Наибольшая разница:"+(max-min));
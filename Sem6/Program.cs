// : Напишите программу, которая будет преобразовывать
//  десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
/*
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

string result ="";

while(num>0)
{
    result=num%2+result;
    num= num/2;
}
Console.WriteLine(result);
*/
/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
Console.WriteLine("Введите число больше 2");
int N = Convert.ToInt32(Console.ReadLine());
int i=2;
if (N>=1)
{
    int[] fib=new int[N];
    fib[0]=0;
    fib[1]=1;
    Console.Write($"{fib[0]} {fib[1] }");//Console.Write("0 1");
while(i<N) //for(int i=2;i<N;i++)
{
    fib[i]=fib[i-1]+fib[i-2];
    Console.Write($" {fib[i]}");
    i++;
}
}
else
{
    Console.WriteLine("Некорректный ввод");
}
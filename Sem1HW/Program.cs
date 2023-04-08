/*
Задача 2: Напишите программу, которая на вход принимает два числа
и выдаёт, какое число большее, а какое меньшее.
*/

Console.WriteLine("Програма определения большего числа (два числа)");
Console.Write("Ведите первое число: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int a2 = Convert.ToInt32(Console.ReadLine());

if (a1==a2) Console.WriteLine("Числа равны (" + a1 + ")");
else if (a1>a2) Console.WriteLine("Первое число (" + a1 + ") больше второго (" + a2 +")");
else Console.WriteLine("Второе число (" + a2 + ") больше первого (" + a1 +")");

/*
Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
*/

Console.WriteLine(" ");
Console.WriteLine("Програма определения большего числа (три числа)");
Console.Write("Ведите первое число: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int b3 = Convert.ToInt32(Console.ReadLine());

int max=b1;
if (b2>max) max=b2;
if (b3>max) max=b3;

Console.Write("Большее число: " + max);

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
*/

Console.WriteLine(" ");
Console.WriteLine("Програма определения чётности");
Console.Write("Ведите число: ");
int c1 = Convert.ToInt32(Console.ReadLine());
if (c1%2==0) Console.WriteLine("Число " + c1 + " чётное");
else Console.WriteLine("Число " + c1 + " не чётное");
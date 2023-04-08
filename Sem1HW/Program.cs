/* Задача 2: Напишите программу, которая на вход принимает два числа
 и выдаёт, какое число большее, а какое меньшее.*/

Console.WriteLine("Програма определения большего числа (два числа)");
Console.Write("Ведите первое число: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int a2 = Convert.ToInt32(Console.ReadLine());
if (a1==a2) Console.WriteLine("Числа равны (" + a1 + ")");
else if (a1>a2) Console.WriteLine("Первое число (" + a1 + ") больше второго (" + a2 +")");
else Console.WriteLine("Второе число (" + a2 + ") больше первого (" + a1 +")");

/*Задача 4: Напишите программу, которая принимает на вход три числа
 и выдаёт максимальное из этих чисел.*/

Console.WriteLine("Програма определения большего числа (три числа)");
Console.Write("Ведите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
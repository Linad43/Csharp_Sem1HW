/* Задача 2: Напишите программу, которая на вход принимает два числа
 и выдаёт, какое число большее, а какое меньшее.*/

Console.WriteLine("Програма определения большего числа");
Console.Write("Ведите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a==b) Console.WriteLine("Числа равны (" + a + ")");
else if (a>b) Console.WriteLine("Первое число (" + a + ") больше второго (" + b +")");
else Console.WriteLine("Второе число (" + b + ") больше первого (" + a +")");


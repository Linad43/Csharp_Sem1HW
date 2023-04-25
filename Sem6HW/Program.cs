/*
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0
ввёл пользователь.
*/

Console.WriteLine("Массив из скольки чисел хотите вводить:");
int length=Convert.ToInt32(Console.ReadLine());

int[] Arr = new int[length];
Console.WriteLine("Введите массив:");
int poloj=0;
for(int i=0;i<Arr.Length;i++)
{
    Console.Write($"A[{i+1}]=");
    Arr[i] = Convert.ToInt32(Console.ReadLine());
    if(Arr[i]>0)
    {
        poloj++;
    }
}

Console.WriteLine("\nКол-во положительных "+poloj);

/*
Задача 43: Напишите программу,
которая найдёт точку пересечения двух прямых,
заданных уравнениями
y = k1 * x + b1,
y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
*/
Console.WriteLine("Нахождение точек пересечение прямых");
Console.WriteLine("Первая прямая\n y = k1 * x + b1");
Console.WriteLine("Введите данные");
Console.Write("k1=");
float k_1=float.Parse(Console.ReadLine());
Console.Write("b1=");
float b_1=float.Parse(Console.ReadLine());
Console.WriteLine("Вторая прямая\n y = k2 * x + b2");
Console.WriteLine("Введите данные");
Console.Write("k2=");
float k_2=float.Parse(Console.ReadLine());
Console.Write("b2=");
float b_2=float.Parse(Console.ReadLine());
float x=(b_2-b_1)/(k_1-k_2);
float y=k_1*x+b_1;
Console.WriteLine($"Точка пересечения O[{x}{y}]");

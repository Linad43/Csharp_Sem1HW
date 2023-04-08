// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Приложение для возведения в квадрат.");
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Квадрат числа " + num  + " равен " + num*num);
/*Console.Write("Квадрат числа ");
Console.Write(num);
Console.Write(" равен ");
Console.Write(num*num);*/

/*
Console.WriteLine("Программа определения квадрата числа");
Console.WriteLine("Введите два числа через enter:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2*num2)
{
    Console.WriteLine("Первое число квадрат второго числа");
}
else if (num1*num1 == num2)
{
    Console.WriteLine("Второе число квадрат первого числа");
}
else
{
    Console.WriteLine("Не является квадратом");
}
*/
/*
Console.WriteLine("Введите число очередности дня недели (число от 1 до 7 включительно)");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1) Console.WriteLine("Этот день недели ПОНЕДЕЛЬНИК");
else if (num == 2) Console.WriteLine("Этот день недели ВТОРНИК");
else if (num == 3) Console.WriteLine("Этот день недели СРЕДА");
else if (num == 4) Console.WriteLine("Этот день недели ЧЕТВЕРГ");
else if (num == 5) Console.WriteLine("Этот день недели ПЯТНИЦА");
else if (num == 6) Console.WriteLine("Этот день недели СУББОТА");
else if (num == 7) Console.WriteLine("Этот день недели ВОСКРЕСЕНЬЕ");
else Console.WriteLine("Такого дня недели не существует");
*/
/*
Console.WriteLine("Введите промежуток (-n...n):");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0) num=-num;

int i=-num;
while(i<=num)
{
    if (i%10==0) 
    {
        Console.WriteLine(i);

    }
    else 
    {
        Console.Write(i);
    }
    Console.Write(" ");
    // Console.WriteLine(i);
    i+=1;
}*/

Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Десятичный остаток от деления числа:" + num%10);
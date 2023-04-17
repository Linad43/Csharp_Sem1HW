/*
Напишите программу,
которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
*/

Console.WriteLine("Введите пятизначное число:");
int num1 = Convert.ToInt32(Console.ReadLine());
int i = 5;
/*while (i>0)
{
    if (num1%(math.pow(10,i))
}
*/

Console.WriteLine($"{num1} -> {num1%Math.Pow(10,i-1)}");

/*
Задача 13: Напишите программу,
которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
*/
/*
int rand = new Random().Next(0,2147483647);
Console.WriteLine($"Случайное число: {rand}");
int three=-1;

if (rand >= 100 && rand < 1000)
{
    three=rand%10;
}
else if (rand >= 1000 && rand < 10000)
{
    three=(rand/10)%10;
}
else if (rand >= 10000 && rand < 100000)
{
    three=(rand/100)%10;
}
else if (rand >= 100000 && rand < 1000000)
{
    three=(rand/1000)%10;
}
else if (rand >= 1000000 && rand < 10000000)
{
    three=(rand/10000)%10;
}
else if (rand >= 10000000 && rand < 100000000)
{
    three=(rand/100000)%10;
}
else if (rand >= 100000000 && rand < 1000000000)
{
    three=(rand/1000000)%10;
}
else if (rand >= 1000000000 && rand < 2147483647)
{
    three=(rand/10000000)%10;
}
if (three == -1)
{
    Console.WriteLine($"{rand} -> нет третьей цифры");
}
else
{
    Console.WriteLine($"{rand} -> {three}");
}

// или проще следующим образом
string sNum = rand.ToString();
if (rand < 100)
{
    Console.WriteLine($"{rand} -> нет третьей цифры");
}
else 
{
    Console.WriteLine($"{rand} -> {sNum[2]}");
}
*/
/*
Задача 15: Напишите программу,
которая принимает на вход цифру,
обозначающую день недели, и проверяет,
является ли этот день выходным.
*/
/*
Console.WriteLine ("Введите число дня недели");
Console.WriteLine ("1. Понедельник");
Console.WriteLine ("2. Вторник");
Console.WriteLine ("3. Среда");
Console.WriteLine ("4. Четверг");
Console.WriteLine ("5. Пятница");
Console.WriteLine ("6. Суббота");
Console.WriteLine ("7. Воскресенье");
int numWeek = Convert.ToInt32(Console.ReadLine());
if (numWeek >= 1 && numWeek <=5)
{
    Console.WriteLine ("Это будний день");
}
else if (numWeek == 6 || numWeek == 7)
{
    Console.WriteLine ("Это выходной день");
}
else
{
    Console.WriteLine ("Не корректные данные");
}
*/
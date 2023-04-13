/*
Напишите программу, которая выводит случайное число
из отрезка [10, 99] и показывает наибольшую цифру числа.
*/
/*
Console.WriteLine("Hello, World!");

int rand = new Random().Next(10,100);
Console.WriteLine($"Случайное число: {rand}");
int one = rand%10;
int two = (rand-one)/10;
Console.WriteLine($"В этом числе две цифры: {two} {one}");
if (one == two)
{
    Console.WriteLine($"Цифры {one} и {two} равны");
}
else if (one < two)
{
    Console.WriteLine($"Цифра {two} больше {one}");
}
else
{
    Console.WriteLine($"Цифра {one} больше {two}");
}*/

/*
Напишите программу, которая выводит случайное трехзначное число
и удаляет вторую цифру этого числа.
*/
/*
int rand = new Random().Next(100,1000);
Console.WriteLine($"Случайное число: {rand}");

int one = rand%10;
int three = rand/100;

Console.WriteLine($"{three}{one}");

int num = three*10+one;
Console.WriteLine(num);
*/
/*
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
*/
/*
Console.WriteLine ("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = number1 % number2;

if( result == 0){
    Console.WriteLine ("Число 2 кратно числу 1");
}
else{
    Console.WriteLine ("Число 2 не кратно числу 1 отстаток " + result);
}
*/
/*
Напишите программу,
которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23
*/
/*
Console.WriteLine ("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Clear();
if (((num1%7)==0)&&((num1%23)==0))
{
    Console.WriteLine ($"{num1}->да");
}
else
{
    Console.WriteLine ($"{num1}->нет");
}
*/
/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.*/

Console.WriteLine ("Введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2*number2) 
{
    Console.WriteLine ($"{number1} квадрат {number2}");
}
else if (number2 == number1*number1) 
{
    Console.WriteLine ($"{number2} квадрат {number1}");
}
else 
{
    Console.WriteLine ($"Числа не квадраты");
}
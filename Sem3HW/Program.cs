/*
Напишите программу,
которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
*/

Console.WriteLine("Введите пятизначное число:");
int num1 = Convert.ToInt32(Console.ReadLine());
//int num1copy=num1;
int N1 = 5;//N1=1
int i = 1;
bool ident=false;
/*
while (num1copy>=10)
{
    num1copy=num1copy/10;
    N1++;
}
*/
while (i<=(N1/2))
{
    if (Math.Floor((num1%Math.Pow(10,i))/(Math.Pow(10,i-1)))==Math.Floor((num1%Math.Pow(10,N1-i+1))/(Math.Pow(10,N1-i))))
    {
        ident = true;
    }
    else
    {
        ident = false;
        break;
    }
    i++;
}
if (ident)
{
    Console.WriteLine("Число палиндром");
}
else
{
    Console.WriteLine("Число не палиндром");
}


//Console.WriteLine($"{num1} -> {Math.Round((num1%Math.Pow(10,i))/(Math.Pow(10,i-1)),0)}");

/*
Напишите программу,
которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
*/

Console.WriteLine("Введите координаты первой точки:");
Console.Write("A(x) = ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("A(y) = ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("A(z) = ");
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
Console.Write("B(x) = ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("B(y) = ");
int By = Convert.ToInt32(Console.ReadLine());
Console.Write("B(z) = ");
int Bz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введены точки:");
Console.WriteLine($"A({Ax},{Ay},{Az})");
Console.WriteLine($"B({Bx},{By},{Bz})");

Console.Write("Расстояние между точками: ");
Console.WriteLine(Math.Pow(Math.Pow(Ax-Bx,2)+Math.Pow(Ay-By,2)+Math.Pow(Az-Bz,2),0.5));


/*
Напишите программу,
которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
*/

Console.WriteLine ("Введите число");
int num3 = Convert.ToInt32(Console.ReadLine());
int i1=2;
Console.Write ($"{num3} -> 1");
while (i1<=num3)
{
    Console.Write ($", {Math.Pow(i1,3)}");
    i1++;
}
Console.Write ($".");

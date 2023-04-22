// Задача 31: Задайте массив из 12 элементов, заполненный
//  случайными числами из промежутка [-9, 9]. 
//  Найдите сумму отрицательных и положительных
//   элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
//  сумма положительных чисел равна 29, сумма отрицательных
//   равна -20.

int[] numArr = new int[12];

int positiveNum=0;
int negNum=0;

for(int i=0;i<numArr.Length;i++)
{
    numArr[i] = new Random().Next(-9,10);

    if(numArr[i]>0)
    {
        positiveNum+=numArr[i];
    }
    else
    {
        negNum+=numArr[i];
    }
}

Console.WriteLine(String.Join(",",numArr)+
"\nСумма положительных "+positiveNum+" отрицательных "+negNum);
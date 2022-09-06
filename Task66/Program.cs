// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в 
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

void ElemSumm1(int x, int y, int sum)
{    
    sum+=y;
    if(y<x)
    {
    Console.Write($"Сумма элементов = {sum}");
    return;
    }
    ElemSumm1(x,y-1,sum);
}

void ElemSumm2(int x, int y, int sum)
{    
    sum+=x;
    if(x<y)
    {
    Console.Write($"Сумма элементов = {sum}");
    return;
    }
    ElemSumm2(x-1,y,sum);
}

if (m<n) ElemSumm1(m,n,0);
else ElemSumm2(m,n,0);

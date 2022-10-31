/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
System.Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine());

void CreatString(int N)
{
    if (N == 1) 
    {
        System.Console.Write($"{N}, ");
        return;
    }
    else 
    {
    System.Console.Write($"{N}, ");
    N-=1;
    CreatString(N);    
    }
}
System.Console.Write($"N = {N} -> ");
CreatString(N);
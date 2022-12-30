/*Задача 63: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int num = 1;

string NumbersRec(int num, int N)
{
    if (num <= N) return $"{num} "+ NumbersRec(num + 1, N);
    else return String.Empty;
}

Console.WriteLine(NumbersRec(num, N));
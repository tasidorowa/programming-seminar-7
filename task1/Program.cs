// Задайте число N. Напишите программу, которая выведет все натуральные числа от 1 до N

void ShowDigits(int n)
{
    if (n == 1)
    {
        Console.Write($"{n} ");
        return;
    }
    ShowDigits(n - 1);
    Console.Write($"{n} ");
}

ShowDigits(50);
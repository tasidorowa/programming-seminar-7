// Напишите программу, которая вычисляет сумму цифр числа n с помощью рекурсии

int SumOfDigits(int num)
{
    if (num == 0)
    {
        return 0;
    }
    int sum = num % 10 + SumOfDigits(num / 10);
    return sum;
}

Console.Write(SumOfDigits(102));
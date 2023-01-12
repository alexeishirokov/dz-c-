void SumNumber(int n, int m)
{
    Console.Write($"Сумму натуральных чисел от {n} до {m} равна = {Sum(n - 1, m)}");
}

int Sum(int n, int m)
{
    int res = n;
    if (n == m)
        return 0;
    else
    {
        n++;
        res = n + Sum(n, m);
        return res;
    }
}

Console.Clear();
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
SumNumber(n, m);

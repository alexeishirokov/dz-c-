int[,] columns = new int[3, 5];
PrintArray(columns);
Console.WriteLine();
MinSum(columns);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void MinSum(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < columns.GetLength(1); i++)
    {
        minRow += columns[0, i];
    }
    for (int i = 0; i < columns.GetLength(0); i++)
    {
        for (int j = 0; j < columns.GetLength(1); j++) sumRow += columns[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"Наименьшая сумма элементов в строке {minSumRow + 1}");
}




void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 99);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы через пробел: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);

Console.Write("Введите позицию первого элемента: ");
int poz1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите позицию второго элемента: ");
int poz2 = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine();

    if (poz1 < 0 | poz1 > matrix.GetLength(0) | poz2 < 0 | poz2 > matrix.GetLength(1))
{
Console.WriteLine("Такой позиции не существует!!!");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", matrix[poz1, poz2]);
}

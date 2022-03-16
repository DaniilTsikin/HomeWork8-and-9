// Спирально заполнить двумерный массив

void Main()
{
    int[,] array = new int[5, 5];
    SnakeFill(array.GetLength(0), array.GetLength(1), array);
}

void PrintArray(int[,] array)
{
    for (int y = 0; y < array.GetLength(0); y++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
            Console.Write($"{array[y, x]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SnakeFill(int endRow, int endCol, int[,] array)
{
    int value = 1;
    int startRow = 0;
    int startCol = 0;

    while (startRow < endRow && startCol < endCol)
    {
        for (int i = startCol; i < endCol; ++i)
            array[startRow, i] = value++;

        startRow++;

        for (int i = startRow; i < endRow; ++i)
            array[i, endCol - 1] = value++;

        endCol--;

        if (startRow < endRow)
        {
            for (int i = endCol - 1; i >= startCol; --i)
                array[endRow - 1, i] = value++;
        }

        endRow--;

        if (startCol < endCol)
        {
            for (int i = endRow - 1; i >= startRow; --i)
                array[i, startCol] = value++;
        }

        startCol++;
    }
    PrintArray(array);
}
Main();


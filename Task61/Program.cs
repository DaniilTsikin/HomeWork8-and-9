// Найти произведение двух матриц
int[,] matrixOne = new int[2, 2];
int[,] matrixTwo = new int[2, 2];

void FillMatrix(int[,] massiv)
{
    Random rand = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = rand.Next(0, 10);
            Console.Write(massiv[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintMatrix(int[,] arr)                                     
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void Multiplication(int[,] massiveOne, int[,] massiveTwo)
{
    int i = 0, j = 0, k = 0, sum = 0, sum2 = 0;
    for (int l = 0; l < massiveOne.GetLength(1); l++)
    {
        sum = massiveOne[i, j] * massiveTwo[k, l] + massiveOne[i, j + 1] * massiveTwo[k + 1, l];
       Console.Write($"{sum} ");
    }
    Console.WriteLine();
    for (int l = 0; l < massiveOne.GetLength(1); l++)
    {
        sum2 = massiveOne[i + 1, j] * massiveTwo[k, l] + massiveOne[i + 1, j + 1] * massiveTwo[k + 1, l];
        Console.Write($"{sum2} ");
    }
    
}

Console.WriteLine("Первая сгенирированная матрица: ");
FillMatrix(matrixOne);
Console.WriteLine("Вторая сгенирированная матрица: ");
FillMatrix(matrixTwo);
Console.WriteLine();
PrintMatrix(matrixOne);
Console.WriteLine();
PrintMatrix(matrixTwo);
Console.WriteLine();
Console.WriteLine("Перемножение матриц 2х2: ");
Multiplication(matrixOne, matrixTwo);

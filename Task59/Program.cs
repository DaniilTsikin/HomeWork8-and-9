// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
int row = 5;       
int col = 4;       


int[,] FillMatrix()                                  
{
    int[,] array = new int[row, col];
    Random num = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = num.Next(1, 10);
        }
    }
    return array;
}

int[] SumRowMatrix(int[,] array)                             // Заполняем новый массив получившимися суммами строк 
{
    int[] arraySum = new int[row];
    int sum = 0;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            sum += array[i, j];
        }
        arraySum[i] = sum;
        sum = 0;
    }
    return arraySum;
}

void MaxMinArray(int[] arr)
{
    int max = 0;
    int min = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        min = arr[i];
        if (arr[i] >= max) max = arr[i]; 
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i]; 
    }
    Console.WriteLine($"Строка с MAX значением = {max}");
    Console.WriteLine($"Строка с MIN значением = {min}");
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

void PtintArr(int[] arr)                                          
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Сумаа строки {i + 1} = {arr[i]}");
    }
    Console.WriteLine();
}


int[,] matrixFirst = FillMatrix();
PrintMatrix(matrixFirst);
Console.WriteLine("==========");

int[] arraySum = SumRowMatrix(matrixFirst);
PtintArr(arraySum);

MaxMinArray(arraySum);

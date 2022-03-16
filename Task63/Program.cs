// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
int[,,] massiv = new int[4, 6, 5];
int count = 10;
void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[i, j, z] = count;
                count++;
            }
        }
    }

}
void PrintMassiv(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("Page №: " + (i + 1));

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
                Console.Write($"{array[i, j, z]} [{i}, {j}, {z}] ");
        Console.WriteLine();
        }
        Console.WriteLine("=====================");
    }
}
FillArray(massiv);
PrintMassiv(massiv);

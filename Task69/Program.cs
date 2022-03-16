// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 15
// M = 4; N = 8. -> 5

void Numbers(int m, int n)
{
    if (m < n)
    {
        FindSum(m, n);
    }

}
void FindSum(int m, int n)
{
    int sum = m;
    while (m < n)
    {
        Console.Write($" {m}, ");
        m++;
        sum = sum + m;
    }
    
    Console.Write(sum);
}

Numbers(1, 15);
Console.WriteLine();
Numbers(4, 8);
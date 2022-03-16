// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

void Numbers(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m}");
        Fill(m,n);
    }

}
void Fill(int m,int n)
{
    while(m < n)
    {
        m++;
        Console.Write($", {m} ");
    }

}

Numbers(1, 5);
Console.WriteLine();
Numbers(4, 8);
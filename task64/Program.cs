// Задача 64: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
void SumFromMtoN(int m, int n, int sum = 0)
{ 
    //System.Console.WriteLine($"{m}, {n}, {sum}");
    sum += m;
    m++;
    if (m > n)
    {
        System.Console.WriteLine($"сумма в данном интервале равна - {sum}");
        return;
    }
    SumFromMtoN(m, n, sum);
}
SumFromMtoN(4, 8);
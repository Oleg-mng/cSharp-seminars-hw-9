// Задача 66: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
int count = 0;
int FuncAckermann(int m, int n)
{
    count++;
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return FuncAckermann(m - 1, 1);
    }
    return FuncAckermann((m - 1), FuncAckermann(m, n - 1));
}
System.Console.WriteLine(FuncAckermann(2, 3));
System.Console.WriteLine($"{count}");

//FunctionAckerman (2, 3) = ack(1, ack(2, 2));

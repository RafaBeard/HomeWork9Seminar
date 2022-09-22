Console.WriteLine("Введите два положительных числа: M и N.");
int m = InputInt("Введите число M: ");
int n = InputInt("Введите число N: ");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}.");
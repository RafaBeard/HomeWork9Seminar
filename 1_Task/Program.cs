int m = InputInt("Введите число M: ");
int n = InputInt("Введите число N: ");
Console.WriteLine(NaturalNumber(m, n));

int NaturalNumber(int m, int n)
{
    if (m == n)
        return m;
    else
        Console.Write($"{NaturalNumber(m, n - 1)}, ");
    return n;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

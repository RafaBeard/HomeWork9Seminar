int m = InputInt("Введите число M: ");
int n = InputInt("Введите число N: ");

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}.");
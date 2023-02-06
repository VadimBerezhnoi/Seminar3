Console.Clear();

int Multi(int number)
{
    int prod = 1;

    for (int i = 1; i <= number; i++)
    {
        prod *= i;
    }
    return prod;
}

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"Произведение чисел от 1 до {N} равно {Multi(N)}");
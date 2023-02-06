Console.Clear();

int GetSum(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
         sum += i;
    }

    return sum;

}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма чисел от 1 до {N} равна {GetSum(N)}");
Console.Clear();

int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void printArray(int[] inArray)

{
    for (int i = 0; i < inArray.Length; i++)

      Console.Write($"{inArray[i]} ");
}

int[] array = GetArray();
printArray(array);

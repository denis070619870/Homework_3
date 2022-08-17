// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int sum = 0;
int size = 20;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array1)
{
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        Console.Write(array1[i] + " ");
        if (i % 2 != 0) sum += array1[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма чисел массива стоящих на нечетной позиции соcтаваляет: {sum} ");
    Console.WriteLine();
}

PrintArray(FillArray(size));
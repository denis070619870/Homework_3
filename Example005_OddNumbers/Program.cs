// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

Console.WriteLine();

int size = 20;
int even = 0;
int oddeven = 0;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintResult(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) even++;
        else oddeven++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел {even}, количество нечетных чисел {oddeven}");
    Console.WriteLine();
}

PrintResult(FillArray(size));

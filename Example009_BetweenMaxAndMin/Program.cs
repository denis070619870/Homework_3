// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int size = new Random().Next(1, 11);

Console.WriteLine($"Количетсов элементов массива: {size}");

double[] FillSourceArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void PrintDiffMinMax(double[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.WriteLine(array1[i]);
    }
    double difference = array1.Max() - array1.Min();
    Console.WriteLine($"Минимальное значение массива {array1.Min()}, максимальное значение массива {array1.Max()}");
    Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
    Console.WriteLine();
}

PrintDiffMinMax(FillSourceArray(size));
Console.WriteLine();

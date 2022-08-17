// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int size = 123;
//int min = -100;
//int max = 200;
int count = 1;

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 201);
    }
    return array;
}

void PrintCountArray(int[] array1)
{
    Console.WriteLine();
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i] + " ");
        if (array1[i] >= 10 && array1[i] <= 99) count++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество чисел из диапазона [10, 99] равно {count}");
    Console.WriteLine();
}
PrintCountArray(FillArray(size, -100, 201));
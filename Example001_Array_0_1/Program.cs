// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int n = 8;
int min = 0;
int max = 1;

int[] CreateArray(int n, int min, int max)
{
    int[] array1 = new int[n];
    for (int i = 0; i < n; i++)
    {
        array1[i] = new Random().Next(min, max +1);
    }
    return array1;
}

void PrintArray(int[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
}

PrintArray(CreateArray(n, min, max));

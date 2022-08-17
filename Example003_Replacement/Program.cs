// Написать программу замену элементов массива на противоположные

int n = 10;

int[] CreateArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

int[] ReplaceArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}

void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        System.Console.Write($"{array1[i]} ");
    }
    System.Console.WriteLine();
}

int[] array = CreateArray(n);
PrintArray(array);
PrintArray(ReplaceArray(array));

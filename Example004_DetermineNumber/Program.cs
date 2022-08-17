// Определить, присутствует ли в заданном массиве, некоторое число

Console.WriteLine("Введите число, чтобы определить, имеется ли оно в массиве? ");
int n = int.Parse(Console.ReadLine());

int size = 10;
int min = 1;
int max = 20;
string Result = "Отсутствует";

int[] CreateArray(int size, int min, int max)
{
    int[] array1 = new int[size];
    for (int i = 0; i < size; i++)
    {
        array1[i] = new Random().Next(min, max + 1);
    }
    return array1;
}

bool ThereIsNumber(int[] array, int n)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == n) return true;
    }
    return false;
}

void PrinArray(int[] array1)
{
    Console.WriteLine();
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
}
int[] array = CreateArray(size, min, max);
PrinArray(array);

if (ThereIsNumber(array, n)) Result = "Присутствует";
Console.WriteLine($"Число {n} {Result} в массиве");
Console.WriteLine();
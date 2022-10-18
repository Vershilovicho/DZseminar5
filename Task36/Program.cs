// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}



void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int[] arr = CreateArrayRndInt(4, -6, 6);
PrintArray(arr);


int SumOddPosition(int[] array)
{
    int sumOddPosition = default;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 == 1) sumOddPosition += array[i];
    }
    return sumOddPosition;
}

int sumOddPos = SumOddPosition(arr);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях -> {sumOddPos}");

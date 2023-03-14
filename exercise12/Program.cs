//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
}

void PrintArray(int[] array)
{
    foreach (var el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

void FindArray(int[] array)
{
    int min = Int32.MaxValue;
    int max = Int32.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
}



int[] array = new int[4];
FillArray(array);
PrintArray(array);
FindArray(array);
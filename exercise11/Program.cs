//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void FillArray(int [] array)
{
    for (int i=0; i<array.Length; i++)
        array [i] = new Random().Next(-10,100);
}

void PrintArray(int [] array)
{
    foreach (var el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

void FindSums(int [] array)
{
    int sumP = 0;
    for (int i=0; i<array.Length; i++)
        if (i % 2 > 0)
            sumP+=array[i];
    Console.WriteLine($"Сумма числел, стоящих на нечётных позициях равна {sumP}");
}


int [] array = new int [5];
FillArray(array);
PrintArray(array);
FindSums(array);

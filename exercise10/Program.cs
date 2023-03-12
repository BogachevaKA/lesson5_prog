//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void FillArray(int [] array)
{
    for (int i=0; i<array.Length; i++)
        array [i] = new Random().Next(100, 999);
}

void PrintArray(int [] array)
{
    foreach (var el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

void FindArray(int [] array)
{
    int cout = 0;
    for (int i=0; i<array.Length; i++)
        if (array[i]%2 == 0)
            cout++;
    Console.WriteLine($"Количество четных чисел в массиве {cout}");
}


int [] array = new int [5];
FillArray(array);
PrintArray(array);
FindArray(array);

// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void PrintArray(int[] array)
{
    Console.Write("Массив: [ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]} ]");
}

int GetEvenNumbers(int[] arr) 
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}



Console.Write("Введите размер массива: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int len);

if(!isNumber || len < 1)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

Random random = new Random();
int[] array = new int[len];
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);
}

PrintArray(array);
Console.WriteLine($"Количество чётных чисел: {GetEvenNumbers(array)}");
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void PrintArray(int[] array)
{
    Console.Write("Массив: [ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]} ]");
}

int GetSumNumbersInOddPositions(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
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
    array[i] = random.Next()*2-1;   //случайные отрицательные и положительные числа
}

PrintArray(array);
Console.WriteLine($"Сумма: {GetSumNumbersInOddPositions(array)}");
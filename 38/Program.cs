// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void PrintArray(double[] array)
{
    Console.Write("Массив: [ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]} ]");
}

double GetMax(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double GetMin(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double GetDiff(double max, double min)
{
    return max-min;
}



Console.Write("Введите размер массива: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int len);

if(!isNumber || len < 1)
{
    Console.WriteLine("Данные введены неверно");
    return;
}

Random random = new Random();
double[] array = new double[len];
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.NextDouble()*2-1;      //случайное вещественное число от -1 до 1
}

PrintArray(array);
Console.WriteLine($"Результат: {GetDiff(GetMax(array), GetMin(array))}");
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
//[3,21 7,04 22,93 -2,71 78,24] -> 80,95

void FillArray(double[] numbers, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Math.Round((rnd.Next(minValue, maxValue) + rnd.NextDouble()), 2);
    }
}

void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {

        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}


int size = 4;
double[] numbers = new double[size];
Console.Write("Введите минимальное число массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
FillArray(numbers, minValue, maxValue);
PrintArray(numbers);
double min = maxValue;
double max = minValue;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
}


Console.WriteLine($"Максимальный элемент в массиве: {max}");
Console.WriteLine($"Минимальный элемент в массиве: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {max - min}");

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void FillArray(int[] nums, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rnd.Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {

        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}


int FindElement(int[] numbers)
{

    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += numbers[i];
        }

    }
    return sum;
}


    int size = 4;
    int[] numbers = new int[size];
    Console.Write("Введите минимальное число массива: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число массива: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    FillArray(numbers, minValue, maxValue);
    PrintArray(numbers);
    int sum = FindElement(numbers);
    Console.WriteLine($"Cумма элементов с нечётными индексами: {sum}");
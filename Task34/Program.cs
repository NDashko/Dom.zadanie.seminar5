// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void FillArray(int[] numbers)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(100, 999);
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

 
 int FindElement (int[] numbers)
{
    
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i]%2 == 0)
        {
            count ++;
        }
    
    }
    return count;
}


    int size = 4;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    int count = FindElement(numbers);
    Console.WriteLine($"Количество четных чисел в массиве - {count}");
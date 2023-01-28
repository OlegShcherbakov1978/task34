// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int count = 0;

int CheckForEven(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int[] array = FillArrayWithRandomNumbers(9, 100, 1000);

PrintArray(array);

CheckForEven(array);

System.Console.WriteLine($"В массиве содержится {count} четнех элементов.");



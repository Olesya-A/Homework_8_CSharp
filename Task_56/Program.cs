// 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int row = EnterInt("Enter row: ");
int col = EnterInt("Enter column: ");
int[,] numbers = new int[row, col];

Fill2DArray(numbers);
Print2DArray(numbers);

Console.WriteLine();

int[] sum = SumOfElementsInRow(numbers);
Console.Write($"Сумма элементов в каждой строке равна ");
PrintArray(sum);

Console.WriteLine();

Console.WriteLine($"Строка с наименьшей суммой элементов: {FindMin(sum) + 1}");

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j],2} ");
        }
        Console.WriteLine();
    }
}

int[] SumOfElementsInRow(int[,] numbers)
{
    int[] sum = new int[numbers.GetLength(0)];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        sum[i] = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum[i] += numbers[i, j];
        }
    }
    return sum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

int FindMin(int[] array)
{
    int min = array[0];
    int indexMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            indexMin = i;
        }
    }
    return indexMin;
}
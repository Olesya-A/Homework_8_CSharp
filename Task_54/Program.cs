//  54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int row = EnterInt("Enter row: ");
int col = EnterInt("Enter column: ");
int[,] numbers = new int[row, col];

Fill2DArray(numbers);
Print2DArray(numbers);

Console.WriteLine();

SortedInDescendingOrder2DArray(numbers);
Print2DArray(numbers);

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
            numbers[i, j] = new Random().Next(1, 11);
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

void SortedInDescendingOrder2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(1) - 1; k++)
            {
                int max = numbers[j, k];
                if (numbers[j, k + 1] > numbers[j, k])
                {
                    Swap(ref numbers[j, k + 1], ref numbers[j, k]);
                }
            }
        }
    }
}

void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
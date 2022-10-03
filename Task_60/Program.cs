// 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] numbers = new int[2, 2, 2];

int[] arrayNoRep = CreateArray(numbers);
PrintArray(arrayNoRep);

Console.WriteLine();

Fill3DArray(numbers, arrayNoRep);
Print3DArray(numbers);

Print3DArrayWithIndex(numbers);

int[] CreateArray(int[,,] array)
{
    int[] arrayNoRep = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    if (arrayNoRep.Length > 90)
    {
        throw new Exception("Нет такого количества двузначных чисел.");
    }
    for (int i = 0; i < arrayNoRep.Length; i++)
    {
        arrayNoRep[i] = new Random().Next(10, 100);
        for (int j = 0; j < i; j++)
        {
            if (arrayNoRep[i] == arrayNoRep[j]) i--;
        }
    }
    return arrayNoRep;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}

void Fill3DArray(int[,,] numbers, int[] array)
{
    int index = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(2); k++)
            {
                numbers[i, j, k] = array[index];
                index++;
            }
        }
    }
}

void Print3DArray(int[,,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(2); k++)
            {
                Console.Write($"{numbers[i, j, k],2} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void Print3DArrayWithIndex(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

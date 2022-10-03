// 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int row1 = EnterInt("Enter row in matrix1: ");
int col1 = EnterInt("Enter column in matrix1: ");
int row2 = EnterInt("Enter row in matrix2: ");
int col2 = EnterInt("Enter column in matrix2: ");

int[,] matrix1 = new int[row1, col1];
int[,] matrix2 = new int[row2, col2];

Fill2DArray(matrix1);
Print2DArray(matrix1);

Console.WriteLine();

Fill2DArray(matrix2);
Print2DArray(matrix2);

Console.WriteLine();

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    int[,] matrixProduct = MatrixMultiplication(matrix1, matrix2);
    Console.WriteLine($"Произведение двух матриц равно:");
    Print2DArray(matrixProduct);
}
else Console.WriteLine($"Произведение двух матриц не существует.");


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

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixProduct = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrixProduct.GetLength(0); i++)
    {
        for (int j = 0; j < matrixProduct.GetLength(1); j++)
        {
            matrixProduct[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrixProduct[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrixProduct;
}
// Для матрицы 2 х 2
// matrixProduct[i, j] = matrix1[i, k] * matrix2[k, j] + matrix1[i, k] * matrix2[k, j];
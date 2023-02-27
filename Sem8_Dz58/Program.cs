// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 3);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] Multiplication(int[,] a, int[,] b)
{
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}



int rows1 = ReadInt("Введите количество строк первого массива: ");
int cols1 = ReadInt("Введите количество столбцов первого массива: ");
int[,] matr1 = GenerateMatrix(rows1, cols1);


int rows2 = ReadInt("Введите количество строк второго массива: ");
int cols2 = ReadInt("Введите количество столбцов второго массива: ");
int[,] matr2 = GenerateMatrix(rows2, cols2);
PrintMatrix(matr1);
System.Console.WriteLine();
PrintMatrix(matr2);
System.Console.WriteLine();
PrintMatrix(Multiplication(matr1, matr2));






// PrintMatrix(matr1);
// System.Console.WriteLine();
// PrintMatrix(matr2);
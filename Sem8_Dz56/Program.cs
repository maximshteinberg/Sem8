// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
            matrix[i, j] = rand.Next(0, 10);
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

int[] CountSum(int[,] matr)
{
    int[] array = new int[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }

        array[i] = sum;
    }
    return array;
}


void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void FindMin(int[] arr)
{
    int min = arr[0];
    int minI=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            minI = i+1;
        }
    }
    System.Console.WriteLine($"Минимальная сумма в строке: {min}");
    System.Console.WriteLine($"Номер строки с минимальной суммой: {minI}");
}


int rows = ReadInt("Введите количество строк массива: ");
int cols = ReadInt("Введите количество столбцов массива: ");
int[,] matr = GenerateMatrix(rows, cols);

PrintMatrix(matr);
PrintArray(CountSum(matr));
FindMin(CountSum(matr));
// // // Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.



// // int ReadInt(string text)
// // {
// //     System.Console.Write(text);
// //     return Convert.ToInt32(Console.ReadLine());
// // }

// // int[,] GenerateMatrix(int rows, int cols)
// // {
// //     Random rand = new Random();
// //     int[,] matrix = new int[rows, cols];
// //     for (int i = 0; i < matrix.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < matrix.GetLength(1); j++)
// //         {
// //             matrix[i, j] = rand.Next(0, 11);
// //         }
// //     }
// //     return matrix;
// // }

// // void PrintMatrix(int[,] matrix)
// // {
// //     for (int i = 0; i < matrix.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < matrix.GetLength(1); j++)
// //         {
// //             System.Console.Write(matrix[i, j] + "\t");
// //         }
// //         System.Console.WriteLine();
// //     }
// // }

// // void Zamena(int[,] matr)
// // {
// //     int temp;
// //     for (int i = 1; i < matr.GetLength(0); i++)
// //     {
// //        for (int j = 1; j < matr.GetLength(1); j++)
// //        {
// //         temp = matr[i, j];
// //         matr[i,j] = matr[j,i];
// //         matr[j,i] = temp;
// //         System.Console.Write(matr[j, i] + "\t");
// //        } 
// //     }   
// // }


// // int rows = ReadInt("Введите количество строк матрицы: ");
// // int cols = ReadInt("Введите количество столбцов матрицы: ");

// // var myMatrix = GenerateMatrix(rows, cols);
// // PrintMatrix(myMatrix);
// // System.Console.WriteLine();
// // Zamena(myMatrix);

// // // PrintMatrix(myMatrix);

// // // Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.


// // int ReadInt(string text)
// // {
// //     System.Console.Write(text);
// //     return Convert.ToInt32(Console.ReadLine());
// // }

// // int[,] GenerateMatrix(int rows, int cols)
// // {
// //     Random rand = new Random();
// //     int[,] matrix = new int[rows, cols];
// //     for (int i = 0; i < matrix.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < matrix.GetLength(1); j++)
// //         {
// //             matrix[i, j] = rand.Next(0, 11);
// //         }
// //     }
// //     return matrix;
// // }

// // void PrintMatrix(int[,] matrix)
// // {
// //     for (int i = 0; i < matrix.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < matrix.GetLength(1); j++)
// //         {
// //             System.Console.Write(matrix[i, j] + "\t");
// //         }
// //         System.Console.WriteLine();
// //     }
// // }

// // int[,] Zamena(int[,] matr)
// // {
// //     int [,] vertical = new int[matr.GetLength(1), matr.GetLength(0)];
// //     for (int i = 0; i < matr.GetLength(1); i++)
// //     {
// //         for (int j = 0; j < matr.GetLength(0); j++)
// //         {
// //         vertical[i,j] = matr[j,i];
// //         }
// //     }
// //     return vertical;
// // }

// // int rows = ReadInt("Введите количество строк матрицы: ");
// // int cols = ReadInt("Введите количество столбцов матрицы: ");

// // var myMatrix = GenerateMatrix(rows, cols);
// // PrintMatrix(myMatrix);

// // System.Console.WriteLine();
// // PrintMatrix(Zamena(myMatrix));


// // Задача 57: Составить частотный словарь элементов двумерного массива. 
// // Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// // int ReadInt(string text)
// // {
// //     System.Console.Write(text);
// //     return Convert.ToInt32(Console.ReadLine());
// // }

// // int[,] GenerateMatrix(int rows, int cols)
// // {
// //     Random rand = new Random();
// //     int[,] matrix = new int[rows, cols];
// //     for (int i = 0; i < matrix.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < matrix.GetLength(1); j++)
// //         {
// //             matrix[i, j] = rand.Next(0, 11);
// //         }
// //     }
// //     return matrix;
// // }

// // void PrintMatrix(int[,] matrix)
// // {
// //     for (int i = 0; i < matrix.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < matrix.GetLength(1); j++)
// //         {
// //             System.Console.Write(matrix[i, j] + "\t");
// //         }
// //         System.Console.WriteLine();
// //     }
// // }

// // void Chastota(int[,] matrix)
// // {

// //     for (int l = 0; l < 10; l++)
// //     {
// //         int count = 0;
// //         for (int i = 0; i < matrix.GetLength(0); i++)
// //         {
// //             for (int j = 0; j < matrix.GetLength(1); j++)
// //             {
// //                 // count = (l == matrix[i, j]) ? count++ : count + 0;
// //                 if (l == matrix[i, j]) count++;
// //             }
// //         }
// //         if (count > 0)
// //         {
// //             System.Console.WriteLine($"{l} встречаетмя {count} раз");
// //         }
// //     }
// // }

// // int rows = ReadInt("Введите количество строк матрицы: ");
// // int cols = ReadInt("Введите количество столбцов матрицы: ");

// // var myMatrix = GenerateMatrix(rows, cols);
// // PrintMatrix(myMatrix);

// / Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// //  Набор данных
// // Частотный массив
// // { 1, 9, 9, 0, 2, 8, 0, 9 }
// // 0 встречается 2 раза 
// // 1 встречается 1 раз 
// // 2 встречается 1 раз 
// // 8 встречается 1 раз 
// // 9 встречается 3 раза


// // 1, 2, 3 
// // 4, 6, 1 
// // 2, 1, 6
// // 1 встречается 3 раза 
// // 2 встречается 2 раз 
// // 3 встречается 1 раз 
// // 4 встречается 1 раз 
// // 6 встречается 2 раза

// // Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.


// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 10);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// // void Chastota(int[,] matrix)
// // {

// //     for (int l = 0; l < 10; l++)
// //     {
// //         int count = 0;
// //         for (int i = 0; i < matrix.GetLength(0); i++)
// //         {
// //             for (int j = 0; j < matrix.GetLength(1); j++)
// //             {
// //                 // count = (l == matrix[i, j]) ? count++ : count + 0;
// //                 if (l == matrix[i, j]) count++;
// //             }
// //         }
// //         if (count > 0)
// //         {
// //             System.Console.WriteLine($"{l} встречаетмя {count} раз");
// //         }
// //     }
// // }

// int[] Chastota(int[,] matrix)
// {
//     var count = new int[10];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             count[matrix[i, j]]++;
//         }
//     }
//     return count;
// }

// void PrintData(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] != 0)
//         {
//             System.Console.WriteLine($"{i} значение встречается {arr[i]} раз");
//         }
//     }
// }
// int rows = ReadInt("Введите количество строк матрицы: ");
// int cols = ReadInt("Введите количество столбцов матрицы: ");

// var myMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(myMatrix);
// PrintData(Chastota(myMatrix));


// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
//  Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза


// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.


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

// void Chastota(int[,] matrix)
// {

//     for (int l = 0; l < 10; l++)
//     {
//         int count = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 // count = (l == matrix[i, j]) ? count++ : count + 0;
//                 if (l == matrix[i, j]) count++;
//             }
//         }
//         if (count > 0)
//         {
//             System.Console.WriteLine($"{l} встречаетмя {count} раз");
//         }
//     }
// }

int[] Chastota(int[,] matrix)
{
    var count = new int[10];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            count[matrix[i, j]]++;
        }
    }
    return count;
}

void PrintData(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0)
        {
            System.Console.WriteLine($"{i} значение встречается {arr[i]} раз");
        }
    }
}
int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");

var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
PrintData(Chastota(myMatrix));
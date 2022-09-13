// Задача 58: Задайте две матрицы. 
// Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int rows1 = 4;
int columns1 = 4;
int rows2 = 4;
int columns2 = 4;
int[,] FillArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1,10);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int [,] MatrixProduct(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int [firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for(int k = 0; k < secondMatrix.GetLength(0); k++)
            {
            resultMatrix [i,j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    } 
    return resultMatrix;
} 
Console.Clear();
int[,] matrix1 = FillArray(rows1, columns1);
int[,] matrix2 = FillArray(rows2, columns2);
PrintArray(matrix1);
Console.WriteLine("----------------");
PrintArray(matrix2);
Console.WriteLine();
MatrixProduct(matrix1, matrix2);
int[,] result = MatrixProduct(matrix1, matrix2);
PrintArray(result);
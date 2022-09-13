// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();

int rows = 4;
int columns = 4;

int[,] FillArray(int m, int n)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                result[i,j] = new Random().Next(1,10);
            }
        
        }
        return result;  
}

void PrintArray(int[,] inArray)
{
    for(int i=0; i < inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1);j++)
        {
            Console.Write($" {inArray [i,j] } ");
        }
        Console.WriteLine();
    }
}


void MinSum(int[,] newArray)
{
    int min = 0;
    int sum1 = int.MaxValue;
    int sum2 = 0;
    int row = 0;
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        sum2 = 0;
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            sum2 = sum2 + newArray[i, j];
        }
        if (sum2 < sum1)
        {
            min = sum2;
            row = i;
        }
        sum1 = sum2;
    }
    Console.WriteLine("Минимальная сумма находится в " + row + " строке и равна -> " + min);
}
int[,] array = FillArray(rows, columns);
PrintArray(array);
MinSum(array);
// Задачрая упора 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Clear();

int rows = 3;
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


void SortArray(int[,] newArray)
{
  for (int i = 0; i < newArray.GetLength(0); i++)
  {
    for (int j = 0; j < newArray.GetLength(1) ; j++)
    {
        for(int k =0; k <newArray.GetLength(1) - 1; k++)
        {
            if (newArray[i,k] < newArray[i, k + 1])
            {
                int temp = newArray[i, k + 1];
                newArray[i,k + 1]  = newArray[i, k];
                newArray[i, k] = temp;
            }

        }
        
        
    }
    
  }
    
}

int[,]array = FillArray(rows, columns);
PrintArray(array);
SortArray(array);
Console.WriteLine();
PrintArray(array);
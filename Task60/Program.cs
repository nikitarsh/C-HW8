// Задача 60. Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)



int rows = 2;
int columns = 2;
int page = 2;
void GetArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int r = 0; r < array3D.GetLength(0); r++)
    {
        for (int c = 0; c < array3D.GetLength(1); c++)
        {
            for (int p = 0; p < array3D.GetLength(2); p++)
            {
                array3D[r, c, p] = temp[count];
                count++;
            }
        }
    }
}
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"| {inArray[i, j, k]} -> {(i, j, k)} |");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int[,,] array1 = new int[rows, columns, page];
GetArray(array1);
PrintArray(array1);
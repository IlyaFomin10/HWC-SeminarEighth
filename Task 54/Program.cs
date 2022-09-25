// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] Getarray (int n, int m)
{
    int[,] array = new int [n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(-1000, 1000);
        }
    }
return array;
}

void OutputDisplay (int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }        
}

int[,] SortingDecreasingArray (int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i,j] < array[i,k])
                {
                    temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
    return array;         
}

Console.WriteLine("Введите количество строк");
int line = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int column = int.Parse(Console.ReadLine());
int[,] array = Getarray (line, column);
int[,] sortingArray = SortingDecreasingArray (array);
OutputDisplay (sortingArray);

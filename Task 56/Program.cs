// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] Getarray (int n)
{
    int[,] array = new int [n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 100);
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

void LineWithMinSum (int[,] array)
{
    int [] sumLine = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumLine[i] = sumLine[i] + array[i,j];
        }
    }
    int minLine = sumLine[0];
    int index = 0;
    for (int k = 1; k < sumLine.Length; k++)
    {
        if (minLine > sumLine[k])
        {
            minLine = sumLine[k];
            index = k;
        }
    }
    Console.WriteLine($"Cтрока {index + 1} имеет наименьшую сумму элементов");
}

Console.WriteLine("Введите количество строк и столбцов");
int size = int.Parse(Console.ReadLine());
int[,] array = Getarray (size);
OutputDisplay (array);
Console.WriteLine();
LineWithMinSum (array);
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] Getarray (int n, int m)
{
    int[,] array = new int [n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(0, 10);
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

int[,] MatrixProduct (int[,] array1, int[,] array2)
{
    int[,] array = new int [array1.GetLength(0), array2.GetLength(1)];
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array2.GetLength(1); j++)
        {
            array[i,j] = 0;
            for(int k = 0; k < array1.GetLength(1); k++)
            {
                array[i,j] += array1[i,k] * array2[k,j];
            }    
        }
    }
    return array;
}
Console.WriteLine("Для того, чтобы сгенерировать два массива, задайте поэтапно их размерность");
Console.WriteLine("Так как мы будем искать произведение матриц внутри массива - количество столбцов первого массива будет равно количеству строк второго");
Console.WriteLine("Введите количество строк первого массива");
int line1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первого массива");
int columnLine = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второго массива");
int column2 = int.Parse(Console.ReadLine());
int[,] array1 = Getarray (line1, columnLine);
int[,] array2 = Getarray (columnLine, column2);
int[,] array = MatrixProduct (array1, array2);
OutputDisplay (array1);
Console.WriteLine();
OutputDisplay (array2);
Console.WriteLine();
OutputDisplay (array);
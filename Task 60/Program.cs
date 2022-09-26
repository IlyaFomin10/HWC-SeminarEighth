// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


void OutputThreeDimensionalArray (int [,,] array)
{
     for (int i = 0; i < array.GetLength(2); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.Write($"{array[j,k,i]}({j},{k},{i}) ");
            }
        Console.WriteLine();    
        }    
    }
}


int [,,] array =
{
    {
        {11, 44, 76},
        {65, 36, 74}
    },

    {
        {52, 33, 12},
        {25, 99, 88}
    }
};

OutputThreeDimensionalArray (array);
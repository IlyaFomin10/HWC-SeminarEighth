// Напишите программу, которая заполнит спирально массив 4 на 4.

int size = 4;
int [,] array = new int [size, size];
int i = 1;
int x = 0;
int y = -1;
int motionRow = 0;
int motionColumn = 1;
while (i <= size*size)
{
    if (0 <= x + motionRow && x + motionRow < size && 0 <= y + motionColumn && y + motionColumn < size && array[x + motionRow, y + motionColumn] == 0)
    {
        x += motionRow;
        y += motionColumn; 
        array[x,y] = i;
        i+=1;
    }
    else  
    {   
        if (motionColumn == 1)
        {
            motionColumn = 0;
            motionRow = 1;
        }    
        else if (motionRow == 1)
        {
            motionRow = 0;
            motionColumn = -1;
        }
        else if (motionColumn == -1)
        {
            motionColumn = 0;
            motionRow = -1;
        }
        else if (motionRow == -1)
        {
            motionRow = 0;
            motionColumn = 1;
        }    
    }
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

OutputDisplay (array);

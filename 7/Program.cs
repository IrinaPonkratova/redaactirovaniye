//Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива.
int [,] CreateArray(int x = 3, int y = 3)
{
    int[,] array = new int[x, y];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1, 10);
        }
    }
    return array;
}
(int x, int y) FindIndexes(int[,] array)
{
    int minXIndex = 0;
    int minYIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] <array[minXIndex, minYIndex])
            {
                minXIndex = i;
                minYIndex = j;
            }
        }
    }
    return(minXIndex, minYIndex);
}
int [,] ChangedArray(int [,] array)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    var min = FindIndexes(array);
    int indexX = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int indexY = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(min.x != i && min.y != j)
            {
                result[indexX,indexY] = array[i,j];
                indexY++;
            }
        }
        if(min.x != i)
        {
            indexX++;
        }
        
    }
    return result;
}
void PrintArray(int [,] array, string msg)
{
    System.Console.WriteLine(msg);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
    }
    System.Console.WriteLine();
}
int [,] basearray = CreateArray();
PrintArray(basearray, "базовый массив");
PrintArray(ChangedArray(basearray), "измененный массив");

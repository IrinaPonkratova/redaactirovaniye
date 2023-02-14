//  Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int [,] CreateArray(int m = 4, int n = 4)
{
    Random rnd = new Random();
    int [,] array = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(0, 5);
        }
    }
    return array;
}
void PrintArray(int [,] array)
{
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
int CheckLowestSumString (int [,] array)
{

    int temp = 0;
    int sum = 0;
    int row = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < temp)
        {
            temp = sum;
            row = i;
        }
    }
    return row+1;
}

int rows = 4;
int col = 4;
int [,] arr = CreateArray(rows, col);
System.Console.WriteLine("исходный массив");
PrintArray(arr);
System.Console.WriteLine($"строка с наименьшей суммой элементов : {CheckLowestSumString(arr)}");
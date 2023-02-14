// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
int InputInt(string msg)
{
    System.Console.WriteLine(msg + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

int [,] CreateArray(int m = 3, int n = 4)
{
    Random rnd = new Random();
    int [,] array = new int [m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-100, 100);
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
int [,]SortDescending ( int [,] array)
{
    for (int rows = 0; rows< array.GetLength(0); rows++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = array.GetLength(1) - 1; j > i; j--)
            {
                if (array[rows, j] > array[rows, j-1])
                {
                    int temp = array[rows, j];
                    array[rows, j] = array[rows, j-1];
                    array[rows, j-1] = temp;
                }
            }
        }   
    }
    
    return array;
}

int rows = 3;
int col = 4;
int [,] arr = CreateArray(rows, col);
System.Console.WriteLine("исходный массив");
//int mess = InputInt("исходный массив");
PrintArray(arr);
//int newMassiv = InputInt("измененный массив: ");
System.Console.WriteLine("измененный массив:");
int [,]result = SortDescending(arr);
PrintArray(result);

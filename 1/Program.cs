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
int SortDescending ( int [,] array)
{
    int max = array[0,0];

    for (int j = 1; j < array.GetLength(1); j++)
    {
        if (array[0,1] > array[0,0])
        {
            int temp = array[0,1];
            array[0,1] = array[0,0];
            array[0,0] = temp;
        }
    }
    return max;
}
void PrintResult(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.WriteLine(array[i,j] + "");
        }
    }
}
int mess = InputInt("исходный массив");
int [,] arr = CreateArray();
PrintArray(arr);
System.Console.WriteLine();
int result = SortDescending(arr);
PrintResult(arr);

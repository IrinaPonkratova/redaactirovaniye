// Задайте две матрицы. Напишите программу, которая будет 
//находить произведение двух матриц.
int [,] CreateArray(int m, int n)
{
    Random rnd = new Random();
    int [,] array = new int [m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
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
int [,] Multiply(int [,] arr1, int [,] arr2)
{
    int [,]newArr = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                newArr[i,j] +=  arr1[i,k] * arr2[k,j];
            }   
        }
    }
    return newArr;
}

int row1 = 3;
int col1 = 4;
int row2 = 4;
int col2 = 3;
int [,] arr1 = CreateArray(row1, col1);
System.Console.WriteLine("исходный 1 массив");
PrintArray(arr1);
int [,] arr2 = CreateArray(row2, col2);
System.Console.WriteLine("исходный 2 массив");
PrintArray(arr2);
System.Console.WriteLine("произведение двух матриц: ");
int [,] newArray = Multiply(arr1, arr2);
PrintArray(newArray);

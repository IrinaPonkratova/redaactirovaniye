//Задайте двумерный массив. Напишите программу, 
//которая поменяет 
//местами первую и последнюю строку массива.
int InputInt(string msg)
{
    System.Console.WriteLine(msg + ": ");
    return Convert.ToInt32(Console.ReadLine());
}
int [,] CreateArray(int lengthStr, int lengthCol)
{
    Random rnd = new Random();
    int [,] array = new int [lengthStr,lengthCol];
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

void Check(int [,] array)
{
    if(array.GetLength(0) != array.GetLength(1))
    {
        System.Console.WriteLine("количество колонок не совпадает с количеством столбцов");
        Environment.Exit(1);
    }
}
int [,] Transponate(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i, j] = array[j,i];
            array[j, i] = temp;
        }
    }
    return array;
}
int lenStr = InputInt("введите количество строк");
int lenCol = InputInt("введите количетсво столбцов");
int [,] myArray = CreateArray(lenStr, lenCol);
Check(myArray);
PrintArray(myArray);
System.Console.WriteLine();
PrintArray(Transponate(myArray));
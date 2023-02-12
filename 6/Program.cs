// Составить частотный словарь элементов двумерного 
//массива. Частотный словарь содержит информацию о том, 
//сколько раз встречается элемент входных данных. 
//Значения элементов массива 0..9
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
            array[i, j] = rnd.Next(0, 10);
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
int []FrequencyDict(int [,] array)
{
    int [] freqDict = new int[10];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            freqDict [array[i,x]]++;
        }
    }
    return freqDict;
}
void PrintDict(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{i} - {array[i]};");
    }
}
int lenStr = InputInt("введите количество строк");
int lenCol = InputInt("введите количетсво столбцов");
int [,] myArray = CreateArray(lenStr, lenCol);
PrintArray(myArray);
System.Console.WriteLine();
int[] freqDict = FrequencyDict(myArray);
PrintDict(freqDict);
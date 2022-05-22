// Задача задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("Hello, World!");
void FillArray (int [,] array,int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] =new Random().Next(1,10);
        }
    }
}

void PrintArray(int [,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        Console.Write (array[i,j]+ " ");
        Console.WriteLine();
    }
}

void SortArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1) - 1; j++)
        for (int k = j + 1; k < array.GetLength(1); k++)
        {
            if (array[i, k] > array[i, j])
            {
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
}   
int [,] array = new int [2,3];
FillArray(array, 1,10);
PrintArray(array);
System.Console.WriteLine();
SortArray(array);
PrintArray(array);
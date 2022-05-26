// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Hello, World!");

int [,] array = {  {9,9,9},
                    {1,6,7},
                    {5,6,7,},
                    {2,2,2}};
int sum = int.MaxValue;
int index = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int temp = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp += array[i, j];
    }
    if (temp < sum)
    {
        sum = temp;
        index = i;
    }
}
Console.WriteLine("Строка: "+index+" Сумма : "+sum);
Console.WriteLine();
for (int i = 0; i < 3; i++)
{
Console.Write(array[index, i]+" "); 
}
 
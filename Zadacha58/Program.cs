// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Hello, World!");


int[,] FillMatrix (string name)
{
    Console.Write("Количество строк матрицы {0}:    ", name);
    var n = int.Parse(Console.ReadLine());
    Console.Write("Количество столбцов матрицы {0}: ", name);
    var m = int.Parse(Console.ReadLine());
    var matrix = new int [n,m];
    for (var i = 0; i < n; i++)
    {
        for (var j = 0; j < m; j++)
        {
            Console.Write(matrix[i,j]+ "");
            matrix[i,j] = new Random().Next(1,3);
        }
    }
    return matrix;
}

void PrintMatirx (int [,] matrix)
{
    for (var i = 0; i < matrix.GetLength(0); i++)
    {
        for (var j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+ "");
        }
        Console.WriteLine();
    }
}

int [,] MatrixMultiplication( int[,] matrixA, int [,] matrixB)
{
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    Console.WriteLine("Умножение матриц невозможно");
}
var matrixC = new int [matrixA.GetLength(0), matrixB.GetLength(1)];
for (var i = 0; i < matrixA.GetLength(0); i++)
{
    for (var j = 0; j < matrixB.GetLength(1); j++)
    {
        matrixC[i,j] = 0;
        for (var k = 0; k < matrixA.GetLength(1); k++)
        {
            matrixC[i,j] += matrixA[i,k] * matrixB[k,j];
        }
    }
}    
    return matrixC;
}
var a = FillMatrix("a");
var b = FillMatrix("b");

Console.WriteLine("matrix a:");
PrintMatirx(a);

Console.WriteLine("matrix b:");
PrintMatirx(b);

var result = MatrixMultiplication(a,b);
Console.WriteLine(" Произведение матриц");
PrintMatirx(result);
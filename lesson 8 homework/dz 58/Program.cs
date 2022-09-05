Console.Clear();
int[,] massiv = new int[2, 2];
System.Console.WriteLine("Матрица 1: ");
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i, j] = new Random().Next(1, 10);
        Console.Write(massiv[i, j] + " ");
    }
    Console.WriteLine();
}

int[,] array = new int[2, 2];
Console.WriteLine("Матрица 2: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

int[,] matrix = new int[2, 2];
Console.WriteLine("Произведение матриц: ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
      for (int k = 0; k < massiv.GetLength(1); k++)
      {
        sum += massiv[i,k] * array[k,j];
      }
      matrix[i,j] = sum;
        
        Console.Write(matrix[i,j]+ " ");
    }
    Console.WriteLine();
}
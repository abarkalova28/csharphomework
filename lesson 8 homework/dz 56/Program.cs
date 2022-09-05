Console.Clear();
int[,] massiv = new int[4, 3];
for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            massiv[i, j] = new Random().Next(1, 10);
            Console.Write(massiv[i, j]+ " ");
        }
    Console.WriteLine();
    }

int Sum (int[,] massiv, int i)
    {
    int sumRow = massiv[i,0];
    for (int j = 1; j < massiv.GetLength(1); j++)
    {
        sumRow += massiv[i,j];
    }
    return sumRow;
    }

int minSumRow = 0;
int sumLine = Sum(massiv, 0);
for (int i = 0; i < massiv.GetLength(0); i++)
    {
    int SumRow  = Sum(massiv, i);
    if (sumLine > SumRow)
    {
        sumLine = SumRow;
        minSumRow = i;
    }
    }
Console.WriteLine();
Console.WriteLine($"{minSumRow+1} - строкa с наименьшей суммой элементов.");
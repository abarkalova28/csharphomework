Console.Clear();
Console.WriteLine("Программа упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine();
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[m, n];

for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1,10);
     
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    
static void SortRow(int[,] m, int r)
    {
        for (int i = 0; i < m.GetLength(1); i++)
            for (int j = i + 1; j < m.GetLength(1); j++)
                if (m[r, i] < m[r, j])
                {
                    int tmp = m[r, i];
                    m[r, i] = m[r, j];
                    m[r, j] = tmp;
                }
    }

for (int i = 0; i < array.GetLength(0); i++)
SortRow(array, i);
Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");

for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
    Console.Write(array[i, j] + " ");
    Console.WriteLine();
    }
   


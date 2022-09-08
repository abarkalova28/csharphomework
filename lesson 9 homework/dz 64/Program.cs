Console.Clear();
Console.WriteLine("Введите значение M:  ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N:  ");
int N = int.Parse(Console.ReadLine());
for(int i=M; i<=N; i++)
    {
        Console.Write(i + ", ");
    }
Console.WriteLine();
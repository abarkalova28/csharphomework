Console.Clear();
Console.WriteLine("Введите значение М: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int N = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = M; i <= N; i++)
    {
        sum += i;
    }
Console.WriteLine("\n" + "Сумма натуральных чисел в промежутке M до N: " + sum);
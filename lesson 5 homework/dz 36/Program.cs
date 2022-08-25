System.Console.Write("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[number];
int sum = 0;
Random rand = new Random();
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rand.Next(-100, 100);
    Console.WriteLine(mass[i]);
    if (i % 2 != 0)
    {
        sum = sum + mass[i];
    }
}
Console.Write("Сумма нечётных элементов массива равна: ");
Console.WriteLine(sum);
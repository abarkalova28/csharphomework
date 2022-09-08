Console.Clear();
Console.WriteLine("Введите значение М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = Akkerman(m, n);
Console.WriteLine("Функция Аккермана равна " +res);
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m != 0) && (n == 0)) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}
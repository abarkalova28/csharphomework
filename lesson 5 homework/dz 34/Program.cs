Console.Clear();
Console.Write("Введите размер массива: ");
int number=Convert.ToInt32(Console.ReadLine());
int [] mass=new int[number];
int Count=0;
Random rand = new Random();
for (int i = 0; i < mass.Length; i++)
    {
    mass[i] = rand.Next(100,999); 
    Console.WriteLine(mass[i]);

    if (mass[i]%2==0)
        {
        Count=Count+1;
        }
    }
Console.Write("Количество четных чисел: ");
Console.WriteLine(Count);
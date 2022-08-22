Console.Write("Введите количество элементов массивa N: ");
int element = int.Parse(Console.ReadLine());
int[] mass=new int [element];
for(int i=0; i<mass.Length; i++)
    {
    System.Console.WriteLine("Введите элементы массива N: ");
    mass[i]=int.Parse(Console.ReadLine());
    }
Console.WriteLine("Массив N: ");
for(int i=0; i<mass.Length; i++)
    {
    Console.WriteLine(mass[i]);
    }
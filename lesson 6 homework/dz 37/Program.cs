Console.Clear();
Console.WriteLine("Массив:");
int N = 10;
int[] array = new int[N];

for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
    }
Console.WriteLine();
Console.WriteLine("Произведение пар чисел в массиве:");
int j = array.Length - 1;
for (int i = 0; i < (array.Length + 1) / 2; i++)
    {
    Console.Write(array[i] * array[j] + " ");
    j--;
    }
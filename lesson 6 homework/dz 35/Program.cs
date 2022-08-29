Console.Clear();
int [] array=new int[123];
int count=0;
for(int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(1,123);
    Console.Write(array[i]+" ");
    if (array[i]>10 && array[i]<99)
        {
         count=count+1;
        }
    }
Console.WriteLine();
Console.Write("Количество элементов в отрезке [10,99]: ");
Console.WriteLine(count);
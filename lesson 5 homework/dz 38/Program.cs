 class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[number];
            int max=0, min=1000;
            Random rand = new Random();
            for (int i = 0; i<array.Length; i++ )  
                array[i] = rand.Next(1000);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
           
               for (int i = 0; i < array.Length; i++) 
               Console.Write(" "+array[i]);
               Console.WriteLine();
                 Console.WriteLine("Максимальный элемент массива:  " + max);
                 Console.WriteLine("Минимальный элемент массива:  " +min);
                 Console.WriteLine("Разница максимального и минимального элемента массива:  "+(max - min));
                Console.ReadKey();
        }
    }
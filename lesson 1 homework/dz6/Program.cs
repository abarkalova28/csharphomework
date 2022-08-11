Console.WriteLine("Введите ваше число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA % 2 == 0)
    {
    Console.WriteLine("Да, число является чётным.");
    }
else
    {
    Console.WriteLine("Нет, число является нечётным.");
    } 
Console.ReadKey();
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());


if(numberA > numberB)
    {
    Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение", numberA, numberB);
    }
else 
    {
    Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение", numberB, numberA);
    }

Console.ReadLine();
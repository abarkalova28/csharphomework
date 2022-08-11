Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberС = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB && numberA > numberС)
    {
    Console.WriteLine("Максимальное число= " + numberA);
    }

else if(numberB > numberС)
    {
    Console.WriteLine("Максимальное число = " + numberB);
    }
else
    {
    Console.WriteLine("Максимальное число = " + numberС);
    }
Console.ReadLine();
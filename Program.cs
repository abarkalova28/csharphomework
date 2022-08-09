// Console.ReadLine() - Получение данных из терминала
// Convert.ToInt32 - из строки преобразуем в число
// Console.WriteLine() - выводит текст на экран
// Создание переменной состоит из Типа данных (int float string bool double) и название переменной

//int number1 = Convert.ToInt32(Console.ReadLine());
//int number2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(number1+number2);

int secretNumber = 7;
int popytki = 3;
bool flagWin =false;
while (popytki > 0)
{
    Console.WriteLine("Введите число от 1 до 10");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    popytki --;
    if(userNumber > secretNumber)
    {
        Console.WriteLine("Секретное число меньше");
        Console.WriteLine("Попыток осталось " + popytki);
    }
    else if (userNumber < secretNumber)
    {
        Console.WriteLine("Секретное число больше");
        Console.WriteLine("Попыток осталось " + popytki);
    }
    else
    {
        Console.WriteLine("Мы выиграли");
        flagWin = true;
        break;
    }
}
if (!flagWin)
{
    Console.WriteLine("Мы проиграли. Число было "+ secretNumber);
}
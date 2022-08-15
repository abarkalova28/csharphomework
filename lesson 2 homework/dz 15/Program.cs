using static System.Console;
Console.WriteLine("Введите цифру, обозначающую день недели");
Console.WriteLine("(Например: 1 - Понедельник, 2 - Вторник, 3 - Среда, 4 - Четверг, 5 - Пятница, 6 - Суббота, 7 - Воскресенье)");

int dayNumber = Convert.ToInt32(Console.ReadLine());

if(dayNumber == 6 ^ dayNumber == 7)
    {
  Console.WriteLine("Да, это выходной день.");
    }
else 
    {
    Console.WriteLine("Нет, это не выходной день.");
    }
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberCheck = Convert.ToString(Number);

if(NumberCheck.Length > 2)
    {
    Console.WriteLine("Третья цифра числа: "+ NumberCheck[2]);
    }
else 
    {
    Console.WriteLine("Третьей цифры нет");
    }
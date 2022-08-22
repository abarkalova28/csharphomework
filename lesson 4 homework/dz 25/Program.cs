Console.Clear();
Console.Write("Программа возводит число А в степень B \r\n");
Console.WriteLine("Введите число A: ");
int A=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число A: ");
int B=Convert.ToInt32(Console.ReadLine());
int result=A;
for(int i=1; i<B; i++)
{
    result=result*A;
}
Console.Write("Число A в степени B равно ");
Console.WriteLine(result);
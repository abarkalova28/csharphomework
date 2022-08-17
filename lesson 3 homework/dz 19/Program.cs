int num, r, t, sum=0;

Console.Write("Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine()); 	
string NumberCheck = Convert.ToString(num);

if(NumberCheck.Length == 5) 
    {
        for(t=num; num!=0; num=num/10){
         r=num % 10;
         sum=sum*10+r;
    }
    if(t==sum)
         Console.Write("{0} - число является палиндромом",t);
    else
         Console.Write("{0} - число не является палиндромом",t);
         }
else
    Console.Write("Ошибка, число не является пятизначным, попробуйте ещё раз.");
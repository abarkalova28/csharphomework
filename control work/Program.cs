using System;
using static System.Console;
Clear();
 
string[] array = {"hello", "2", "world", ":-)"};

WriteLine($"В массиве [{String.Join(", ", array)}] количество строк, длина которых меньше либо равна трём символам {Counter(array)} это - {StringFinder(array)}");
WriteLine();

int Counter(string[] ar)
{
   int count = 0;
   for(int i = 0; i < ar.Length; i++)
   {
       if(ar[i].Length <= 3)
       {
           count++;
       }
   }
   return count;
}
string StringFinder(string[] arrStr)
{
   string result = String.Empty;
   for(int i = 0; i < arrStr.Length; i++)
   {
       if(arrStr[i].Length <= 3)
       {
           result += $"{arrStr[i]} ";
       }
   }
   return result;
}
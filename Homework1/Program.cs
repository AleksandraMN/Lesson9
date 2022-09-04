/*Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

using System;
class Program
{ 
static string NumbersRec(int a, int b)
{
    if (a<b) return $"{a}" + ", " + NumbersRec(a+1, b); // если а<b, при помощи  рекурсии выводятся числа от а до b-1. 
	 if (a>b) return $"{a}" + ", " + NumbersRec(a-1, b); // если а>b, при помощи  рекурсии выводятся числа от а до b-1.
    else return String.Empty;
}

static public void Main(string[] args)
{
	Console.WriteLine(); 	
	Console.Write("Введите число M = ");
	int M = int.Parse(Console.ReadLine());
	Console.Write("Введите число N = ");
	int N = int.Parse(Console.ReadLine());	
	Console.Write("''");
	Console.Write(NumbersRec(M, N) + $"{N}"+ ".");
	Console.Write("''");
	Console.WriteLine(); 	
}
}

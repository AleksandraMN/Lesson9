/*Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/

using System;
class Program
{ 
static double A (double m, double n) //вычисления функции Аккермана с помощью рекурсии для малых значений  m и n.
{
    if (m==0) return n+1; 
    else if((m!=0) && (n==0)) return A(m-1, 1);
	 else return A(m-1, A(m, n-1)); 
}
static public void Main(string[] args)
{
	Console.WriteLine(); 	
	Console.Write("Введите число m = ");
	double m = Double.Parse(Console.ReadLine());
	Console.Write("Введите число n = ");
	double n = Double.Parse(Console.ReadLine());	
	Console.WriteLine("A(m,n) = " + $"{A(m, n)}" + ".");	
	Console.WriteLine();
}  
}



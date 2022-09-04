/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using System;
class Program
{ 
static int SumFor(int a, int b) // Метод: возвращает результат - сумма чисел от a до b - с рекурсией.
{
	if (a<b) return (a + SumFor(a+1, b));
	if (a>b) return (a + SumFor(a-1, b));
	else return 0;
}
static public void Main(string[] args)
{
	Console.WriteLine(); 	
	Console.Write("Введите число M = ");
	int M = int.Parse(Console.ReadLine());
	Console.Write("Введите число N = ");
	int N = int.Parse(Console.ReadLine());
	if (M==N) Console.WriteLine("Сумма натуральных элементов в промежутке от M до N = 0.");
	else Console.WriteLine("Сумма натуральных элементов в промежутке от M до N = {0}. ", SumFor(M, N)+ N);		
	Console.WriteLine(); 
}
}






/*

Метод - без рекурсии:
static int SumFor(int a, int b) // Метод: возвращает результат - сумма чисел от a до b - без рекурсии.
{
	int result = 0;
   if (a<b) // если число a < числа b
	{
		for(int i = a; i<=b; i++) result += i;
	 	return result;
	} 
    else if(a>b)// если число a > числа b
	{		                                               
		for(int i = a; i>=b; i--) result += i;
	 	return result;
	} else return 0; // если число a = числу b
	} */
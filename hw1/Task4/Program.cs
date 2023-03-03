//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 1. Задача 4.
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());
int thirdNum = Convert.ToInt32(Console.ReadLine());

int maxNum = firstNum;

if (secondNum > maxNum) maxNum = secondNum;
if (thirdNum > maxNum) maxNum = thirdNum;
Console.WriteLine($"Максимальное число из трёх {maxNum}");
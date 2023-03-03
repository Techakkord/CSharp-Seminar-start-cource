//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 1. Задача 2.
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secondNum) Console.WriteLine($"Число {firstNum} больше числа {secondNum}"); 
else if (secondNum > firstNum) Console.WriteLine($"Число {secondNum} больше числа {firstNum}");
else if (firstNum == secondNum) Console.WriteLine("Введённые числа равны");
else Console.WriteLine("Не удалось сравнить значения");
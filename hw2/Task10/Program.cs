//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 2. Задача 10.
/*Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа. 
 Через строку решать нельзя..*/
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = Convert.ToInt32(Console.ReadLine());
int absNum = Math.Abs(number);
int result = -404;

if (absNum > 99 && absNum <= 999)
{
    absNum /= 10;
    result = absNum  % 10;
    Console.WriteLine(result);

}else Console.WriteLine("Некорректный ввод");   
//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 1. Задача 7.
/* Напишите программу, которая принимает на вход целое число 
любой разрядности и на выходе 
показывает третью цифру слева этого числа или говорит, 
что такой цифры нет. 
Через строку решать нельзя.*/

int number = Convert.ToInt32(Console.ReadLine());
int result = -404;

if (number >= 100)
{
    while (number > 999){
        {
            number = number / 10;
        }  
    }
    result = number % 10;
    Console.WriteLine(result);

}else if (number<0 ) Console.WriteLine("Некорректный ввод"); 
else Console.WriteLine("Число короткое и не содержит третью цифру слева");          
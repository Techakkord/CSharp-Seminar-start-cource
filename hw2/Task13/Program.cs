//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 2. Задача 13.
/*Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
Через строку решать нельзя..*/
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = Convert.ToInt32(Console.ReadLine());
int absNum = Math.Abs(number);
int result = -404;

if (absNum >= 100)
{
    while (absNum > 999){
        {
            absNum = absNum / 10;
        }  
    }
    result = absNum % 10;
    Console.WriteLine(result);

}else Console.WriteLine("Число короткое и не содержит третью цифру слева");          
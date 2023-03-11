//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 4. Задача 25.
/*Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.*/
//!возможно здесь опечатка, формулировка про цикл не совсем корректная
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(getPow(A, B));


int getPow(int num, int degree)
{
    int result = -404;
    if(degree==0) result = 1; 
    else{ 
        result = num;
        for (int count = degree; count > 1; --count)
        {
            result *= num;
        }
    }
    return result;
}
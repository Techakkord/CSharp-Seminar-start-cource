﻿//Знакомство с языками программирования (семинары)
//ДЗ 9. Задача 64
/*Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.*/
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 
int N = 5;
getRecursion(N);

N = 8;
getRecursion(N);

void getRecursion(int num){
    if(num>=1){ 
        Console.WriteLine(num);
        num--;
        getRecursion(num);
    }
    else Console.WriteLine("---------");
}

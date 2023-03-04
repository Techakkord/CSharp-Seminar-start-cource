﻿//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 2. Задача необязательная FIZZ BUZZ.

/*Напишите программу, которая выводит на экран числа от 1 до 100. 
При этом вместо чисел, кратных трем, программа должна выводить слово Fizz,
а вместо чисел, кратных пяти — слово Buzz. Если число кратно пятнадцати,
то программа должна выводить слово FizzBuzz. 
Задача может показаться очевидной, 
но нужно получить наиболее простое и красивое решение..*/
for(int i = 1; i <= 100; ++i){
    string num = Convert.ToString(i), fizz = "Fizz", buzz="Buzz"; 
    if(i%3!=0) fizz=""; else num=""; 
    if(i%5!=0) buzz=""; else num=""; 
    Console.Write($"{num}{fizz}{buzz} "); 
}
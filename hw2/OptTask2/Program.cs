﻿//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 2. Доп задача2.

/*В институте биоинформатики по офису передвигается робот. 
Недавно студенты из группы программистов написали для него программу, 
по которой робот, когда заходит в комнату, считает количество программистов в ней и 
произносит его вслух: "n программистов".
Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание
слова.
Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), 
выводящее это число в консоль вместе с правильным образом изменённым словом "программист", 
для того, чтобы робот мог нормально общаться с людьми, 
например: 1 программист, 2 программиста, 5 программистов.
В комнате может быть очень много программистов. Проверьте, что ваша программа правильно 
обработает все случаи, как минимум до 1000 человек.*/

int proggerNum = Convert.ToInt32(Console.ReadLine());

string proggerWord = "программист";
string pluralWordEnding = "ов";
string nominativeWordEnding = "";
string genitiveWordEnding = "а";

int tmp = proggerNum;

if(proggerNum >= 0){
    tmp %= 100;
    if (tmp >=11 && tmp <=19) proggerWord += pluralWordEnding;
    else{
        tmp %= 10;
        if(tmp==1) proggerWord += nominativeWordEnding; //по идее в этот момент мы делаем лишнее действие, не изменяя строку, 
                                                        //однако, считаю необходимым оставить для прослеживания логики работы программы
        else if (tmp>=2 && tmp<=4) proggerWord += genitiveWordEnding;
        else proggerWord += pluralWordEnding;
    } 
    Console.WriteLine($"{proggerNum} {proggerWord}");
}else Console.WriteLine("Некорректный ввод количества человек");
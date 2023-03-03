//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 1. Задача 8.
/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.*/
int start = 1;
int count = 0;
int curNum = start;
int N = Convert.ToInt32(Console.ReadLine());

if(N >= start && N > 0){
    while(curNum <= N){
        if(curNum % 2 == 0){
            Console.Write($"{curNum} ");
            ++count;        
        } 
        ++curNum;
    }
    if(count == 0) Console.WriteLine("В заданном диапазоне нет чётных значений");
}else Console.WriteLine("Введено некорректное значение");
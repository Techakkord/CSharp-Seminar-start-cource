//Знакомство с языками программирования (семинары)
//ДЗ 9. Задача 66
/*Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.*/
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = 1;
int N = 15;
Console.WriteLine(getSum(M,N));

M =4;
N =8;
Console.WriteLine(getSum(M,N));

int getSum(int start, int end){
    if(start == end) return end;
    else if(start<end) 
        return  start + getSum(start+1, end); 
    else return start + getSum(start -1, end);
}
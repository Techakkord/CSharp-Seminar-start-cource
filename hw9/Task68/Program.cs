//Знакомство с языками программирования (семинары)
//ДЗ 9. Задача 68
/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

uint m =2, n=3;
Console.WriteLine(getAkker(m,n));
m =3; n =2;
Console.WriteLine(getAkker(m,n));

uint getAkker(uint m, uint n){
    if(m == 0) return n+1;
    else if ((m != 0 ) && (n==0)) return getAkker(m-1, 1);
    else return getAkker(m-1,getAkker(m,n-1));
}
//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 4. Задача 27.
/*Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.*/
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sumOfDigits(num));

int sumOfDigits(int number){
    int temp = number;
    int sum = 0;
    while(temp >= 1){
        sum += temp % 10;
        temp /= 10; 
    }
    return sum;
}
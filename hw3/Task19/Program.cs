//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 3. Задача 19.
/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. Через строку решать нельзя.*/
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void isPalindrome (int num){
    int reverse = 0;
    int temp = num;
    while (temp != 0) {
        reverse = (reverse * 10) + (temp % 10);
        temp = temp / 10;
    }
    if (reverse == num) Console.Write("Number is palindrome");
    else Console.Write("Number is not palindrome");
}

/*bool isPalindrome (int num){
    int reverse = 0;
    int temp = num;
    while (temp != 0) {
        reverse = (reverse * 10) + (temp % 10);
        temp = temp / 10;
    }
    return (reverse == num);
}*/

int number = Convert.ToInt32(Console.ReadLine());
isPalindrome(number);

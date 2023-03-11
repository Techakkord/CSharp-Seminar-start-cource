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

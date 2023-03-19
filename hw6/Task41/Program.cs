//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 6. Задача 41.
/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь*/
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4 (в условиях на сайте опечатка)
int M = 5;
int[] exmpArr1 = getArray(M);
int[] exmpArr2 = getArray(M);

displayArr(exmpArr1);
Console.WriteLine($" => {getPositiveCount(exmpArr1)}");

displayArr(exmpArr2);
Console.WriteLine($" => {getPositiveCount(exmpArr2)}");

int[] getArray(int size = 3){
    int[] arr = new int[size];
    for(int i = 0; i < size; ++i){
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

 void displayArr(int[] array){
    for(int i = 0; i < array.Length; ++i){
        if(i==0)Console.Write($"["); 
        if(i==array.Length-1) Console.WriteLine($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
 }
 
 int getPositiveCount(int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; ++i)
    {
        if(arr[i]>0) ++count;
    }
    return count;
 }
//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 5. Задача 34.
/*Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве*/
// [345, 897, 568, 234] -> 2
int[] arr = getRandArr(4);
Console.WriteLine($"=> {getEvenCount(arr)}");

int[] getRandArr(int quantity){
    int[] arr = new int[quantity];
    for (int i = 0; i < quantity; ++i)
    {
        Random rand = new Random();
        arr[i] = rand.Next(100,999);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

int getEvenCount(int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; ++i)
    {
        if(arr[i]%2 == 0) ++count;
    }
    return count;
}    
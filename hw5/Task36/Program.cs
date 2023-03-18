//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 5. Задача 36.
/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов,стоящих на нечётных позициях*/
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = getRandArr(7);
Console.WriteLine($"=> {getOddSum(arr)}");  


int[] getRandArr(int quantity){
    int[] arr = new int[quantity];
    for (int i = 0; i < quantity; ++i)
    {
        Random rand = new Random();
        arr[i] = rand.Next(-10,10);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

int getOddSum(int[] arr){
    int sum = 0;
    Console.Write($"=>");
    for (int i = 0; i < arr.Length; ++i)
    {
        if(i % 2 != 0){
            sum+= arr[i];
            Console.Write($" {arr[i]} ");
        } 
    }
    return sum;
}


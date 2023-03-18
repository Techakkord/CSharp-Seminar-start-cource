//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 5. Задача 38.
/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/
// [3 7 22 2 78] -> 76

double[] arr = getRandDoubleArr(5); 
Console.WriteLine($"=> {getExtremeDiff(arr)}");  


double[] getRandDoubleArr(int quantity){
    double[] arr = new double[quantity];
    for (int i = 0; i < quantity; ++i)
    {
        Random rand = new Random();
        arr[i] = Math.Round(rand.NextDouble() * 100,2);
        Console.WriteLine(arr[i]);
    }
    return arr;
}

double getExtremeDiff(double[] arr){
    double diff = 0;
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; ++i)
    {
        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
    }
    Console.WriteLine($"max = {max}; min = {min}");    
    diff = Math.Round((max - min), 2);
    return diff;
} 
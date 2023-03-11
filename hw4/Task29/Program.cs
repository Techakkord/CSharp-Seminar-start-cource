//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 4. Задача 29.
/*Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.*/
//!некорректная формулировка задачи
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] exmp1 = getArray(5);
int[] exmp2 = getArray(3);
int[] arr1 = getArray(8);
int[] arr2 = getRandArray(8);

displayArr(exmp1);
displayArr(exmp2);
displayArr(arr1);
displayArr(arr2);

int[] getArray(int size = 3){
    int[] arr = new int[size];
    for(int i = 0; i < size; ++i){
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int[] getRandArray(int size = 3){
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < size; ++i){
        arr[i] = rnd.Next() % rnd.Next(10,100);
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
//Знакомство с языками программирования (семинары)
//ДЗ 7. Задача 47
/*Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.*/

int m = 4;
int n = 3;
int[,]arr = MyArr.getArr(m,n);
MyArr.displayArr(arr);

public static class MyArr{
    public static void displayArr(int[] array){
        for(int i = 0; i < array.Length; ++i){
            if(i==0)Console.Write($"["); 
            if(i==array.Length-1) Console.WriteLine($"{array[i]}]");
            else Console.Write($"{array[i]}, ");
        }
    }
    public static void displayArr(int[,] array){
        for(int j = 0; j < array.GetLength(1); ++j){
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
    }
    public static int[] getArr(int size = 3){
        int[] arr = new int[size];
        for(int i = 0; i < size; ++i){
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        return arr;
    }
    public static int[,] getArr(int m, int n){
        int[,] arr = new int[m,n];
        Random rnd =new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i,j] = rnd.Next(-50,50);
            }
        }
        return arr;
    }   
}
 

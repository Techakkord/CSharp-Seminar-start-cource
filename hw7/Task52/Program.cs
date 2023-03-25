//Знакомство с языками программирования (семинары)
//ДЗ 7. Задача 52
/*Задайте двумерный массив из целых чисел. Найдите 
среднее арифметическое элементов в каждом столбце.*/
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int m = 3;
int n = 4;
int[,]arr = MyArr.getArr(m,n);
MyArr.displayArr(arr);
double [] listAverage = MyArr.getListAverage(arr);
MyArr.displayArr(listAverage);
public static class MyArr{
    public static void displayArr(int[] array){
        for(int i = 0; i < array.Length; ++i){
            if(i==0)Console.Write($"["); 
            if(i==array.Length-1) Console.WriteLine($"{array[i]}]");
            else Console.Write($"{array[i]}, ");
        }
    }
    public static void displayArr(double[] array){
        for(int i = 0; i < array.Length; ++i){
            if(i==0)Console.Write($"["); 
            if(i==array.Length-1) Console.WriteLine($"{array[i]}]");
            else Console.Write($"{array[i]} ");
        }
    }
    public static void displayArr(int[,] array){
       Console.WriteLine("---------------");
        for(int i = 0; i < array.GetLength(0); ++i){
            for (int j = 0; j < array.GetLength(1); ++j)
            {
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("---------------");
    }
    public static int[] getArr(int size = 3){
        int[] arr = new int[size];
        for(int i = 0; i < size; ++i){
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        return arr;
    }
    public static int[,] getArr(int columns = 2,int rows = 2){
        int[,] arr = new int[columns,rows];
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                arr[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        return arr;
    }
    public static int[,] getRandArr(int m, int n){
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
    public static int[,] findNum(int num,int [,] arr){

        int [,] position = {{-404},{-404}}; 
        int count = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i,j] == num){
                    position[0,0] = i;
                    position[1,0] = j;
                    ++count;
                    
                }
            }
            
        }
        if(count==0) Console.WriteLine("Такого числа нет");
        return position;
    } 
    public static double[] getListAverage(int[,] arr){
        double sum= 0;
        double quantity = Convert.ToDouble(arr.GetLength(1)); 
        double[] average = new double[arr.GetLength(1)];  

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum =0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum+=arr[i,j]; 
            }
            average[j] = sum/quantity;
        } 
        return average;
    }
}
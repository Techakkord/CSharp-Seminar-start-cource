//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 6. Задача 43.
/* Напишите программу, которая найдёт точку пересечения двух 
прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.*/
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[] func1Vars = {5, 2};
double[] func2Vars = {9, 4};
IntersectionPoint(func1Vars,func2Vars);
double[] IntersectionPoint(double[] f1Vars, double[] f2Vars){
    double k1 = f1Vars[0];
    double b1 = f1Vars[1];
    double k2 = f2Vars[0];
    double b2 = f2Vars[1];
    double x = 0;
    double y = 0;
    bool isInters = true;
    double[] intersPoint = {0,0};
    if(k1==k2 && b1==b2){
        isInters = false;
        Console.WriteLine("Прямые совпадают, бесконечное количество решений");
        Console.WriteLine($"({isInters})");   
    }
    else if(k1==k2){
        isInters = false;
        Console.WriteLine("Прямые параллельны, точек пересечения нет"); 
        Console.WriteLine($"({isInters})");  
    }
    else{
        x = (b2 - b1)/(k1 -k2);
        y = k1* x + b1;
        Console.WriteLine($"({x};{y})");
        intersPoint[0] = x;
        intersPoint[1] = y;  
    }
    return intersPoint;
 
}
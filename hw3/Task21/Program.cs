///Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 3. Задача 21.
/*Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.*/
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Point3D A = new(3,6,8);
Point3D B = new(2,1,-7);
double resultDistance1 = getVectorModulus(A,B);
Console.WriteLine(string.Format("{0:f2}",resultDistance1));

Point3D C = new(7,-5,0);
Point3D D = new(1,-1,9);
double resultDistance2 = getVectorModulus(C,D);
Console.WriteLine(string.Format("{0:f2}",resultDistance2));

double getVectorModulus(Point3D point1, Point3D point2){
    double powX = Math.Pow((point2.X-point1.X),2);
    double powY = Math.Pow((point2.Y-point1.Y),2);
    double powZ = Math.Pow((point2.Z-point1.Z),2);
    double result = Math.Sqrt(powX+powY+powZ); 
    return result;
}
public struct Point3D
{
    public double X = 10;
    public double Y = 5;
    public double Z = 8;
    public override string ToString()
    {
        return $"({X},{Y},{Z})";
    }
    public Point3D(double x) : this()
    {
        X = x;
        Y = 0;
        Z = 0;
    }
    public Point3D(double x, double y) : this(x)
    {
        Y = y;
        Z = 0;
    }
    public Point3D(double x, double y, double z) : this(x, y)
    {
        Z = z;
    }
}












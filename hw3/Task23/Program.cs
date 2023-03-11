///Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 3. Задача 23.
/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.*/
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number  = Convert.ToInt32(Console.ReadLine());
getCubesList(number);

void getCubesList(int num){
    for(int i = 1; i <= num; ++i){
        Console.Write($"{Math.Pow(i,3)} "); 
    }
}
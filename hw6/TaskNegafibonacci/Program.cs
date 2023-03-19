//Евгений Филимонов 
//Знакомство с языками программирования (семинары)
//ДЗ 6. Задача Негафибоначчи.
// Задайте число. Составьте список чисел НегаФибоначчи, 
// в том числе для отрицательных индексов.
// *Пример:*
// - для k = 9 список будет выглядеть так: 
// [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

int k = 9;
int[] arrFb = getNegaFibList(k);
displayArr(arrFb);

int[] getNegaFibList(int num){
    int[] fb = new int[num*2-1];
    if(num>1){   
        // int prevNeg = 0;
        // int nextNeg = 1; 
        int prev = 0;
        int next = 1;
        
        fb[num-2] = next; 
        fb[num-1] = 0;//середина массива
        fb[num] = next;
         
        for (int i = 1; i < num-1; i++)
        {
            next = prev + next;
            fb[num+i] = next;
            if(i % 2 ==0) fb[num-(i+2)]= next;
            else fb[num-(i+2)]= -next;
            prev = next - prev;
        }
        
    }
    return fb;
}
void displayArr(int[] array){
    for(int i = 0; i < array.Length; ++i){
        if(i==0)Console.Write($"["); 
        if(i==array.Length-1) Console.WriteLine($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
 }
 

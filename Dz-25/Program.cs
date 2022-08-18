/* Напишите цикл, которы принимает на вход 2 числа (A и B)
и возводит A в натуральную степень B. */ 

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень B: ");
int B = int.Parse(Console.ReadLine());
/* Console.WriteLine("Введите степень C: ");  // работа с дополнительной степенью "C"
int C = int.Parse(Console.ReadLine()); */

int Nums(int num)  // num -  название переменной, с которой работаем в цикле
{ 
    int pro = 1;
    for (int i = 1; i <= num; i++) // без цикла можно воспользоваться Math.Pow(A, B);
    {
        pro = pro * A;  
        //Console.WriteLine(pro); // для наглядности
    }
    return(pro);
}
Console.WriteLine(Nums(B)); //  B - введенное число, с которым работает функция, вместо "int num" 
// Console.WriteLine(Nums(C)); // - работа с дополнительной степенью "C", не нужно писать отдельный цикл для каждго решения.
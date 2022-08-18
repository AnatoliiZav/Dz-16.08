/* Напишите цикл, которы принимает на вход 2 числа (A и B)
и возводит A в натуральную степень B. */ 

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень B: ");
int B = int.Parse(Console.ReadLine());

int Nums(int B)
{ 
    int pro = 1;
    for (int i = 1; i <= B; i++) // без цикла можно воспользоваться Math.Pow(A, B);
    {
        pro = pro * A;  
        //Console.WriteLine(pro); // для наглядности
    }
    return(pro);
}
Console.WriteLine(Nums(B));

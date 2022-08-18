/* Напишите функцию и запустите ее, которая принимает на вход
число  и выдает сумму цифр в числе. */

Console.WriteLine("Введите число: ");
int X = int.Parse(Console.ReadLine());

Console.WriteLine(SumNums(X)); 

int SumNums(int nu)
{
    int sum = 0;
    while ( nu > 0 )
    {
        int b = nu % 10;
        sum = sum + b;  
        nu = nu / 10;
    }
    return(sum);  
}


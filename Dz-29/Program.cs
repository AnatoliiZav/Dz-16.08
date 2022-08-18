/* Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами 
из [a, b) и выводит их на экран. */


Console.WriteLine("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = int.Parse(Console.ReadLine());

void Rand()
{
    int[] arriva = new int [N];

    for (int i = 0; i < arriva.Length; i++)  
    {
        arriva[i] = new Random().Next(A,B);
    }
    Console.WriteLine($"[{String.Join(",", arriva)}]"); 
}

Rand();

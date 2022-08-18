/* Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами 
из [a, b) и выводит их на экран. */


Console.WriteLine("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = int.Parse(Console.ReadLine());

/*  if (A >B)
{
    int min = B;
    int max = A;
}
else
{
    int min = A;
    int max = B;
}

Console.WriteLine(min, max); */

void Rand()
{
    int[] arriva = new int [N];

    for (int i = 0; i < arriva.Length; i++)  /* arr - название массива, Length - длина массива, 
    всегда вернет длину массива, выгоднее, чем использование конкретной цифры, при изменении длины массива, 
    чтобы не забыть и не запутаться Например, выше длину массива 8 можно поменять на любую*/
    {
        arriva[i] = new Random().Next(A,B);
        //Console.Write("{0} ", arriva[i]); первый метод вывода
    }
    Console.WriteLine($"[{String.Join(",", arriva)}]"); // Второй метод вывода, String - строка
}

Rand();

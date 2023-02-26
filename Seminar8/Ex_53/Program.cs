// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.



int[,] AutoFillArr()
{
    System.Console.Write("Введите количество строк массива (m): ");
    int str = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов массива (n): ");
    int col = Convert.ToInt32(Console.ReadLine());

    int[,] arr = new int[str, col];

    System.Console.Write("Введите начало диапазона генерации для автозаполнения: ");
    int first = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите конец диапазона генерации для автозаполнения: ");
    int last = Convert.ToInt32(Console.ReadLine());


    for (int m = 0; m < arr.GetLength(0); m++)
    {

        for (int n = 0; n < arr.GetLength(1); n++)
        {
            arr[m, n] = new Random().Next(first, last + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int m = 0; m < arr.GetLength(0); m++) // строки
    {
        for (int n = 0; n < arr.GetLength(1); n++) // столбцы
        {
            System.Console.Write($"{arr[m, n]} ");
        }
        System.Console.WriteLine();
    }
}

void ReverseString(int[,] arr)
{
    int ARRSTRINGFIRST = 0;
    int ARRSTRINGLAST = arr.GetLength(1) - 1;

    int[] temp = new int[arr.GetLength(1)];


    for (int n = 0; n < arr.GetLength(1); n++) temp[n] = arr[ARRSTRINGFIRST, n];

    for (int n = 0; n < arr.GetLength(1); n++) arr[ARRSTRINGFIRST, n] = arr[ARRSTRINGLAST, n];

    for (int n = 0; n < arr.GetLength(1); n++) arr[ARRSTRINGLAST, n] = temp[n];
}


System.Console.Clear();
int[,] array = AutoFillArr();
PrintArray(array);

System.Console.WriteLine();
ReverseString(array);

PrintArray(array);
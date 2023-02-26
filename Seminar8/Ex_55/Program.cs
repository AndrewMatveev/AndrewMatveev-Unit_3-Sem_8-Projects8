// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.


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

int[,] TranspArr(int[,] arr)
{
    int[,] arrtrans = new int[arr.GetLength(1), arr.GetLength(0)];

    for (int str = 0; str < arrtrans.GetLength(0); str++)
    {
        for (int col = 0; col < arrtrans.GetLength(1); col++)
        {
            arrtrans[str, col] = arr[col, str];
        }
    }
    return arrtrans;
}


System.Console.Clear();
int[,] array = AutoFillArr();
PrintArray(array);

System.Console.WriteLine();
int[,] array2 = TranspArr(array);

PrintArray(array2);
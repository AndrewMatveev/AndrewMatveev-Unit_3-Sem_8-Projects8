// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


int[,] AutoFillArr(out int first, out int last)
{
    System.Console.Write("Введите количество строк массива (m): ");
    int str = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите количество столбцов массива (n): ");
    int col = Convert.ToInt32(Console.ReadLine());

    int[,] arr = new int[str, col];

    System.Console.Write("Введите начало диапазона генерации для автозаполнения: ");
    first = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите конец диапазона генерации для автозаполнения: ");
    last = Convert.ToInt32(Console.ReadLine());


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


void Minimun(int[,] arr, out int minI, out int minJ)
{
    minI = 0;
    minJ = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[minI, minJ] > arr[i, j])
            {
                minI = i;
                minJ = j;
            }
        }

    }
}


int[,] NewMatrix(int[,] arr, int minI, int minJ)
{
    int[,] newMatr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int k = 0;
    int l = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i != minI) // проверка на совпадение со строкой, содержащей минимальное значение
        {
            l = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j != minJ) // проверка на совпадение со столбцом, содержащим минимальное значение
                {
                    newMatr[k, l] = arr[i, j];
                    l++;
                }

            }
            k++;
        }
    }
    return newMatr;
}
// _______________________________________________




System.Console.Clear();
int[,] array = AutoFillArr(out int first, out int last);
PrintArray(array);

System.Console.WriteLine();

Minimun(array,  out int minI, out int minJ);
System.Console.WriteLine();

System.Console.WriteLine($"{minI}, {minJ}");
System.Console.WriteLine();

PrintArray(NewMatrix(array, minI, minJ));



// FindMin(array, out int minm, out int minn);

// System.Console.WriteLine($"{minm} $ {minn}");
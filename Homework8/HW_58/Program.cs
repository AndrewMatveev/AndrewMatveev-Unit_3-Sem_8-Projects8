// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] AutoFillArr(string txt)
{
    Console.Write($"Введите количество строк матрицы под названием {txt} (i): ");
    int str = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите количество столбцов матрицы под названием {txt} (j): ");
    int col = Convert.ToInt32(Console.ReadLine());

    int[,] arr = new int[str, col];

    Console.Write($"Введите начало диапазона генерации для автозаполнения матрицы под названием {txt}: ");
    int first = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите конец диапазона генерации для автозаполнения матрицы под названием {txt}: ");
    int last = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(first, last + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) // строки
    {
        for (int j = 0; j < arr.GetLength(1); j++) // столбцы
        {
            System.Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
        System.Console.WriteLine();
    }
}

void MatrixMultiplication(int[,] arr1, int[,] arr2)
{
    if (arr1.GetLength(1) == arr2.GetLength(0)) //количество столбцов первой матрицы должно быть равно количеству строк второй матрицы
    {
        int strandcol = arr1.GetLength(0); // по условию решения они равны поэтому колинки и столбцы названы одинаково
        int sumtemp = 0;
        int[,] resultarr = new int[strandcol, strandcol];

        for (int str = 0; str < strandcol; str++) // счетчик сметы строк
        {
            for (int col = 0; col < strandcol; col++) // счетчик смены колонок
            {
                for (int indx = 0; indx < strandcol; indx++) // перемножение по строке в первом массиве и по колонке во втором
                {
                    sumtemp = sumtemp + arr1[str, indx] * arr2[indx, col];
                }
                resultarr[str, col] = sumtemp;
                sumtemp = 0;
            }
        }
    PrintArray(resultarr);
    }
    else System.Console.WriteLine("Решения матрицы не существует");
}


// ________________________________ТЕЛО КОДА____________________________________________


System.Console.Clear();

int[,] array1 = AutoFillArr("Альфа-Массив");
System.Console.WriteLine();

int[,] array2 = AutoFillArr("Бета-Массив");
System.Console.WriteLine();
System.Console.WriteLine();


System.Console.WriteLine("Полученны массивы: ");
System.Console.WriteLine();

PrintArray(array1);
System.Console.WriteLine();

PrintArray(array2);
System.Console.WriteLine();

System.Console.WriteLine("Результат работы программы по умножению матриц:");
System.Console.WriteLine();
MatrixMultiplication(array1, array2);
System.Console.WriteLine();
System.Console.WriteLine();
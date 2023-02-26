// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] AutoFillArr(out int first, out int last)
{
    Console.Write("Введите количество строк массива (i): ");
    int str = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива (j): ");
    int col = Convert.ToInt32(Console.ReadLine());

    int[,] arr = new int[str, col];

    Console.Write("Введите начало диапазона генерации для автозаполнения: ");
    first = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конец диапазона генерации для автозаполнения: ");
    last = Convert.ToInt32(Console.ReadLine());


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

double[] SumStringElem(int[,] arr)
{
    double[] SumArr = new double[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++) // когда сначала задаём m то он фиксирует строку
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++) // а тут перемещается по столбцам т.е. идет вправо вдоль строки
        {
            sum = sum + arr[i, j];
        }
        SumArr[i] = sum;


        // _____________________________________________________________________________________
        // Console.Write($"Сумма {i} строки равна {sum}"); // для построчного вывода суммы строк
        // System.Console.WriteLine();

    }
    return SumArr;
}

void FindMinSum(double[] SumArr)
{
    int min = 0;
    for (int i = 0; i < SumArr.Length; i++)
    {
        if (SumArr[i] < SumArr[min]) min = i;
        else if (SumArr[min] == SumArr[i]) min = min;
    }
    System.Console.WriteLine($"Первая попавшаяся строка с наименьшей суммой элеметов под индексом {min}");
}






// ________________________________ТЕЛО КОДА____________________________________________


System.Console.Clear();

int[,] array = AutoFillArr(out int first, out int last);
PrintArray(array);

double[] SumResult = SumStringElem(array);
System.Console.WriteLine();

// Console.WriteLine(string.Join("\t", SumResult)); // для вывода массива с суммами соотв строк

FindMinSum(SumResult);
System.Console.WriteLine();



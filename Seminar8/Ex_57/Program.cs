// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.


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


// void IterationCount(int[,] arr) // вариант 1 с перебором значений по двумерному массиву
// {
//     int count = 0;
//     for (int m = 0; m < arr.GetLength(0); m++) // строки
//     {
//         for (int n = 0; n < arr.GetLength(1); n++) // столбцы
//         {
//             int find = arr[m, n];




//             for (int i = 0; i < arr.GetLength(0); i++)
//             {
//                 for (int j = 0; j < arr.GetLength(1); j++)
//                 {
//                     if (find == arr[i, j])
//                     {
//                         count++;
//                     }
//                 }
//             }
//             System.Console.WriteLine($"{find} встретился {count} раз(а)");
//             count = 0;



//         }

//     }
// }


int[] IterationCount(int[,] arr, int first, int last) // вариант 2 с выводом попадающихся чисел по возрастанию
{
    int[] count = new int[last + 2 - first];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) count[arr[i, j]]++;
    }
    return count;
}
void PrintIterationInfo(int[] count)
{
    for (int i = 0; i < count.Length; i++)
    {
        if (count[i] != 0) Console.WriteLine($"{i} значение встречается {count[i]} раз");
    }
}




System.Console.Clear();
int[,] array = AutoFillArr(out int first, out int last);
PrintArray(array);

System.Console.WriteLine();

PrintIterationInfo(IterationCount(array, first, last));
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

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



void NormalizeStr(int[,] arr)
{
    for (int str = 0; str < arr.GetLength(0); str++)
    {
        int[] TempArr = new int[arr.GetLength(0)];
        for (int k = 0; k < TempArr.Length; k++) TempArr[k] = arr[str, k];

        for (int i = 0; i < TempArr.Length; i++) //проходим по массиву с начала и до конца
        {
            int min = i; //считаем, что минимальный элемент имеет текущий индекс 
            for (int j = i; j < TempArr.Length; j++) //ищем минимальный элемент дальше
            {
                if (TempArr[j] < TempArr[min]) min = j;
            }

            if (TempArr[min] != TempArr[i])
            {
                int temp = TempArr[i];
                TempArr[i] = TempArr[min];
                TempArr[min] = temp;
            }
        }

        for (int k = 0; k < TempArr.Length; k++) arr[str, k] = TempArr[k];
    }

}




System.Console.Clear();
int[,] array = AutoFillArr(out int first, out int last);
PrintArray(array);
System.Console.WriteLine();
NormalizeStr(array);
PrintArray(array);
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

string[,,] AutoFillArr(string txt)
{
    Console.Write($"Введите размер матрицы под названием {txt} по оси х: ");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите размер матрицы под названием {txt} по оси y: ");
    int width = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите размер матрицы под названием {txt} по оси z: ");
    int depth = Convert.ToInt32(Console.ReadLine());

    string[,,] arr = new string[length, width, depth];

    Console.Write($"Введите начало диапазона генерации для автозаполнения матрицы под названием {txt}: ");
    int first = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите конец диапазона генерации для автозаполнения матрицы под названием {txt}: ");
    int last = Convert.ToInt32(Console.ReadLine());

    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                int rand = new Random().Next(first, last + 1);
                arr[x, y, z] = String.Concat(Convert.ToString(rand), " [", Convert.ToString(x),",", Convert.ToString(y),",", Convert.ToString(z), "]");
            }
        }
    }
    return arr;
}

void PrintArray(string[,,] arr)
{
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                System.Console.Write($"{arr[x, y, z]}\t");
            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine();
    }
}



// ________________________________ТЕЛО КОДА____________________________________________


System.Console.Clear();

string[,,] array1 = AutoFillArr("Трехмерный массив");
System.Console.WriteLine();

System.Console.WriteLine("Получен массив: ");
System.Console.WriteLine();

PrintArray(array1);
System.Console.WriteLine();
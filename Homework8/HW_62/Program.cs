// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] FillMatrix(string txt)
{
    System.Console.Write(txt);
    int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    int[,] matrix = new int[size[0], size[1]];

    int temp = 1;
    int str = 0;
    int col = 0;

    while (temp <= matrix.GetLength(0) * matrix.GetLength(1)) // пока 
    {
        matrix[str, col] = temp;
        if (str <= col + 1 && str + col < matrix.GetLength(1) - 1) col++;
        else if (str < col && str + col >= matrix.GetLength(0) - 1) str++;
        else if (str >= col && str + col > matrix.GetLength(1) - 1) col--;
        else str--;
        temp++;
    }

    return matrix;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
        System.Console.WriteLine();
    }
}



// ________________________________ТЕЛО КОДА____________________________________________



System.Console.Clear();

int[,] MyMatrix = FillMatrix("Введите размерность массива [строка, столбец]\nВвод: ");

System.Console.WriteLine();
System.Console.WriteLine();

PrintMatrix(MyMatrix);
System.Console.WriteLine();
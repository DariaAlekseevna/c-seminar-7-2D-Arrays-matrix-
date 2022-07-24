// двумерный массив, найти эл-ты, у кот. оба индекса четные и заменить элементы на их квадраты.

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n]; //инцилизир. двумер.массив
    var rnd = new Random(); //создаем экземпляр класса, который имеет метод генерации случ чисел
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] mtrx)
{
    string s = new string('-', 23);
    System.Console.WriteLine(s);
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (j == 0) System.Console.Write(" | ");
            System.Console.Write($"{mtrx[i, j], 2} | ");
        }
        System.Console.WriteLine();
    }
    System.Console.Write(s);
}

/* void MatrixEvElemSq(int[,] matrx)
{
    for (int i = 0; i < matrx.GetLength(0); i++)
    {
        for (int j = 0; j < matrx.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrx[i, j] *= matrx[i, j];
            }
        }
    }
}   */

int[,] MatrixEvElemSq(int[,] matrx)
{
    for (int i = 0; i < matrx.GetLength(0); i++)
    {
        for (int j = 0; j < matrx.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrx[i, j] *= matrx[i, j];
            }
        }
    }
    return(matrx);
}

int[,] result = GetMatrix(4, 4, 1, 9);
PrintMatrix(result);
System.Console.WriteLine();
MatrixEvElemSq(result);
System.Console.WriteLine("в матрице эл-ты, у которых оба индекса четные заменены на их квадраты: ");
PrintMatrix(result);
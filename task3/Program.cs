// массив m*n, каждый эл-т которого находится по формуле Аmn = m+n. 

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] mtrx)
{
    string s = new string('-', 19);
    System.Console.WriteLine(s);
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (j == 0) System.Console.Write(" | ");
            System.Console.Write($"{mtrx[i, j],1} | ");
        }
        System.Console.WriteLine();
    }
    System.Console.Write(s);
}

int[,] result = GetMatrix(4, 4);
PrintMatrix(result);
System.Console.WriteLine();
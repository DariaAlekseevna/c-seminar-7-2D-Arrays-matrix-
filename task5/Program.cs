// в двумерном массиве найти сумму эл-тов на главной диагонали.

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
            System.Console.Write($"{mtrx[i, j],2} | ");
        }
        System.Console.WriteLine();
    }
    System.Console.Write(s);
}

void MatrixSumDiagElem(int[,] matrx)
{
    int sum = 0;
    for (int i = 0; i < matrx.GetLength(0); i++)
    {
        for (int j = 0; j < matrx.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matrx[i, j];
            }
        }
    }
    System.Console.WriteLine(" сумма элементов по главной диагонали равна: " + sum);
}

void MatrixSumDiagElem2(int[,] matrx)
{
    int sum = 0;
    int index = 0;
    if (matrx.GetLength(0) > matrx.GetLength(1))
    {
        index = 1;
    }
    for (int i = 0; i < matrx.GetLength(index); i++)
    {
        sum += matrx[i, i];
    }
    System.Console.WriteLine(" сумма элементов по главной диагонали равна: " + sum);
}


int[,] result = GetMatrix(6, 4, 1, 10);
PrintMatrix(result);
System.Console.WriteLine();
MatrixSumDiagElem(result);
System.Console.WriteLine();
MatrixSumDiagElem2(result);
System.Console.WriteLine();
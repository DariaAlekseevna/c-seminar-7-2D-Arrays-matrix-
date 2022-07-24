//массив m*n заполненный случ. числами


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

void PrintMatrix(int[,] mtrx) //не возвращает значение
{
    string s = new string('-', 23);
    System.Console.WriteLine(s);
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (j == 0) System.Console.Write(" | ");
            System.Console.Write($"{mtrx[i, j], 2 /*ширина слевой стороны*/} | ");
        }
        System.Console.WriteLine();
    }
    System.Console.Write(s);
}

int[,] result = GetMatrix(3, 4, 1, 20); //записываем метод в переменную
PrintMatrix(result);
System.Console.WriteLine();

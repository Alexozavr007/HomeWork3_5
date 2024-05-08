using HomeWork3_5_3;

var matrix = new MyMatrix(4, 2);
matrix.RowsCount = 3;

// заповнення 1го стовпчика
matrix[0, 0] = 21;
matrix[0, 1] = 22;
matrix[0, 2] = 23;

// 2
matrix[1, 0] = 51;
matrix[1, 1] = 52;
matrix[1, 2] = 53;

// 3
matrix[2, 0] = 99;
matrix[2, 1] = 99;
matrix[2, 2] = 99;

// 4
matrix[3, 0] = -10;
matrix[3, 1] = -20;
matrix[3, 2] = -30;

for (int i = 0; i < matrix.RowsCount; i++)
{
    Console.WriteLine();
    for (int j = 0; j < matrix.ColumnsCount; j++)
    {
        Console.Write($"{matrix[j, i]} ");
    }
}
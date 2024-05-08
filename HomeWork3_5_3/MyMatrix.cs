using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_5_3
{
    internal class MyMatrix
    {

        int[,] matrix;

        public MyMatrix(int columns, int rows)
        {
            matrix = new int[columns, rows];
        }

        public int ColumnsCount
        {
            get { return matrix.GetLength(0); }
            set
            {
                matrix = new int[value, RowsCount];
            }
        }

        public int RowsCount
        {
            get { return matrix.GetLength(1); }
            set
            {
                matrix = new int[ColumnsCount, value];
            }
        }


        public int this[int column, int row] {
            get {
                return matrix[column, row];
            }
            set {
                matrix[column, row] = value;
            }
        }

    }
}

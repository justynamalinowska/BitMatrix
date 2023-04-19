using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BitMatrixNameSpace
{
    public partial class BitMatrix
    {

        public static explicit operator BitMatrix(int[,] array)
        {
            if (array == null)
                throw new NullReferenceException();

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            if (rows == 0 || columns==0)
                throw new ArgumentOutOfRangeException();

            BitMatrix matrix = new BitMatrix(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] != 0)
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;
                }
            }

            return matrix;
        }

        public static explicit operator BitMatrix(bool[,] array)
        {
            if (array == null)
                throw new NullReferenceException();

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            if (rows == 0 || columns == 0)
                throw new ArgumentOutOfRangeException();

            BitMatrix matrix = new BitMatrix(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] != false)
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;
                }
            }

            return matrix;
        }

        public static implicit operator int[,](BitMatrix matrix)
        {
            int rows = matrix.NumberOfRows;
            int columns = matrix.NumberOfColumns;

            int[,] array = new int[rows,columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] != 0)
                        array[i, j] = 1;
                    else
                        array[i, j] = 0;
                }
            }
            return array;
        }

        public static implicit operator bool[,](BitMatrix matrix)
        {
            int rows = matrix.NumberOfRows;
            int columns = matrix.NumberOfColumns;

            bool[,] array = new bool[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] != 0)
                        array[i, j] = true;
                    else
                        array[i, j] = false;
                }
            }
            return array;
        }

        public static explicit operator BitArray(BitMatrix matrix)
        {
            int rows = matrix.NumberOfRows;
            int columns = matrix.NumberOfColumns;

            if (matrix == null)
                throw new NullReferenceException();

            if (rows == 0 || columns == 0)
                throw new ArgumentOutOfRangeException();

            BitArray bits = new BitArray(rows * columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == 1)
                        bits.Set(i * matrix.NumberOfColumns + j, true);
                    else
                        bits.Set(i * matrix.NumberOfColumns + j, false);
                } 
            }
            return bits;
        }
    }
}
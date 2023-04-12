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
        public BitMatrix(int numberOfRows, int numberOfColumns, params int[] bits)
        {
            data = new BitArray(numberOfRows * numberOfColumns);

            if (bits != null && bits.Length > 0)
            {
                for (int i = 0, k = 0; i < numberOfRows; i++)
                {
                    for (int j = 0; j < numberOfColumns; j++, k++)
                    {
                        if (k < bits.Length)
                            data[i * numberOfColumns + j] = BitToBool(bits[k]);
                        else
                            data[i * numberOfColumns + j] = false;
                    }
                }
            }

            NumberOfRows = numberOfRows;
            NumberOfColumns = numberOfColumns;
        }

        public BitMatrix(int[,] bits)
        {
            if (bits == null)
                throw new NullReferenceException();

            int numberOfRows = bits.GetLength(0);
            int numberOfColumns = bits.GetLength(1);

            if (bits.Length == 0)
                throw new ArgumentOutOfRangeException();

            data = new BitArray(numberOfRows * numberOfColumns);

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    data[i * numberOfColumns + j] = BitToBool(bits[i, j]);
                }
            }

            NumberOfRows = numberOfRows;
            NumberOfColumns = numberOfColumns;
        }

        public BitMatrix(bool[,] bits)
        {
            if (bits == null)
                throw new NullReferenceException();

            int numberOfRows = bits.GetLength(0);
            int numberOfColumns = bits.GetLength(1);

            if (bits.Length == 0)
                throw new ArgumentOutOfRangeException();

            data = new BitArray(numberOfRows * numberOfColumns);

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    data[i * numberOfColumns + j] = bits[i, j];
                }
            }

            NumberOfRows = numberOfRows;
            NumberOfColumns = numberOfColumns;
        }

    }
}

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
        public BitMatrix And(BitMatrix other)
        {
            if (other == null)
                throw new ArgumentNullException();

            if (other.NumberOfColumns != this.NumberOfColumns || other.NumberOfRows != this.NumberOfRows)
                throw new ArgumentException();

                for (int i = 0; i < this.NumberOfRows; i++)
                {
                for (int j = 0; j < this.NumberOfColumns; j++)
                    this[i, j] &= other[i, j];
                }
                return this; 
        }

        public static BitMatrix operator &(BitMatrix x, BitMatrix y)
        {
            if (x == null || y==null)
                throw new ArgumentNullException();

            if (x.NumberOfColumns != y.NumberOfColumns || x.NumberOfRows != y.NumberOfRows)
                throw new ArgumentException();

            BitMatrix matrix = new BitMatrix(x.NumberOfRows, y.NumberOfColumns);

            for (int i = 0; i < x.NumberOfRows; i++)
            {
                for (int j = 0; j < y.NumberOfColumns; j++)
                    matrix[i,j] = x[i, j] & y[i, j];
            }
            return matrix;
        }

        public BitMatrix Or(BitMatrix other)
        {
            if (other == null)
                throw new ArgumentNullException();

            if (other.NumberOfColumns != this.NumberOfColumns || other.NumberOfRows != this.NumberOfRows)
                throw new ArgumentException();

            for (int i = 0; i < this.NumberOfRows; i++)
            {
                for (int j = 0; j < this.NumberOfColumns; j++)
                    this[i, j] |= other[i, j];
            }
            return this;
        }

        public static BitMatrix operator |(BitMatrix x, BitMatrix y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException();

            if (x.NumberOfColumns != y.NumberOfColumns || x.NumberOfRows != y.NumberOfRows)
                throw new ArgumentException();

            BitMatrix matrix = new BitMatrix(x.NumberOfRows, y.NumberOfColumns);

            for (int i = 0; i < x.NumberOfRows; i++)
            {
                for (int j = 0; j < y.NumberOfColumns; j++)
                    matrix[i, j] = x[i, j] | y[i, j];
            }
            return matrix;
        }
        public BitMatrix Xor(BitMatrix other)
        {
            if (other == null)
                throw new ArgumentNullException();

            if (other.NumberOfColumns != this.NumberOfColumns || other.NumberOfRows != this.NumberOfRows)
                throw new ArgumentException();

            for (int i = 0; i < this.NumberOfRows; i++)
            {
                for (int j = 0; j < this.NumberOfColumns; j++)
                    this[i, j] ^= other[i, j];
            }
            return this;
        }

        public static BitMatrix operator ^(BitMatrix x, BitMatrix y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException();

            if (x.NumberOfColumns != y.NumberOfColumns || x.NumberOfRows != y.NumberOfRows)
                throw new ArgumentException();

            BitMatrix matrix = new BitMatrix(x.NumberOfRows, y.NumberOfColumns);

            for (int i = 0; i < x.NumberOfRows; i++)
            {
                for (int j = 0; j < y.NumberOfColumns; j++)
                    matrix[i, j] = x[i, j] ^ y[i, j];
            }
            return matrix;
        }

        public BitMatrix Not()
        {
            if (this == null)
                throw new ArgumentNullException();

            for (int i = 0; i < this.NumberOfRows; i++)
            {
                for (int j = 0; j < this.NumberOfColumns; j++)
                    if (this[i, j] == 0)
                        this[i, j] = 1;
                    else
                        this[i, j] = 0;
            }
            return this;
        }

        public static BitMatrix operator !(BitMatrix x)
        {
            if (x == null)
                throw new ArgumentNullException();

            BitMatrix matrix = new BitMatrix(x.NumberOfRows, x.NumberOfColumns);

            for (int i = 0; i < x.NumberOfRows; i++)
            {
                for (int j = 0; j < x.NumberOfColumns; j++)
                    if (x[i, j] == 0)
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;
            }
            return matrix;
        }

    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BitMatrixNameSpace
{
    public partial class BitMatrix : ICloneable
    {
        public object Clone()
        {
            BitMatrix clonedMatrix = new BitMatrix(NumberOfRows, NumberOfColumns);
            for (int i = 0; i < NumberOfRows; i++)
            {
                for (int j = 0; j < NumberOfColumns; j++)
                    clonedMatrix[i, j] = this[i, j];
            }
            return clonedMatrix;
        }
    }
}

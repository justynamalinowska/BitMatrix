using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BitMatrixNameSpace
{
    public partial class BitMatrix : IEnumerable<int>
    {
        public int this[int i, int j]
        {
            get
            {
                int index = i * NumberOfColumns + j;
                return data[index] ? 1 : 0;
            }
            set
            {
                if (i < 0 || j < 0 || i >= NumberOfRows || j >= NumberOfColumns)
                    throw new IndexOutOfRangeException();

                int index = i * NumberOfColumns + j;
                data[index] = BitToBool(value);
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < NumberOfColumns; i++)
            {
                for (int j = 0; j < NumberOfRows; j++)
                {
                    yield return this[i, j];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

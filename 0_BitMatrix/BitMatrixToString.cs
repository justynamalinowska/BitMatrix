using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_BitMatrix
{
    internal partial class BitMatrix
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < NumberOfRows; i++)
                for (int j = 0; j < NumberOfColumns; j++)
                    sb.Append(BoolToBit(data[i * i]));
            sb.AppendLine();

            return base.ToString();
        }
    }
}

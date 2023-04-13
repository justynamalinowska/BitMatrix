using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BitMatrixNameSpace
{

    public partial class BitMatrix : IEquatable<BitMatrix>
    {
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is BitMatrix))
                return false;

            BitMatrix other = (BitMatrix)obj;

            if (other.NumberOfRows != this.NumberOfRows || other.NumberOfColumns != this.NumberOfColumns)
                return false;

            for (int i = 0; i < this.data.Length; i++)
            {
                if (this.data[i] != other.data[i])
                    return false;
            }

            return true;
        }

        bool IEquatable<BitMatrix>.Equals(BitMatrix other)
        {
            return Equals(other);
        }

        public override int GetHashCode()
        {
            return data.GetHashCode();
        }

        public static bool operator ==(BitMatrix m1, BitMatrix m2)
        {
            if (ReferenceEquals(m1, m2))
                return true;

            else if (m1 == null || m2 == null)
                return false;

            else
                return m1.Equals(m2);
        }

        public static bool operator !=(BitMatrix m1, BitMatrix m2)
        {
            return !(m1 == m2);
        }
    }

}
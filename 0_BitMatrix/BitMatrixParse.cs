using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BitMatrixNameSpace
{
    public static BitMatrix Parse(string s)
    {
        if (s == null || s.Length == 0)
            throw new ArgumentNullException();

        var lengths = s.Split(new[] { Environment.NewLine, " " }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 1; i < lengths.Length; i++)
        {
            if (lengths[i - 1].Length != lengths[i].Length)
                throw new FormatException();
        }
        int Columns = lengths[0].Length;
        int Rows = lengths.Length;
        int[] values = new int[Columns * Rows];

        for (int i = 0, k = 0; i < lengths.Length; i++)
        {
            for (int j = 0; j < lengths[i].Length; j++, k++)
            {
                if (lengths[i][j] != '0' && lengths[i][j] != '1')
                    throw new FormatException();

                values[k] = lengths[i][j] == '1' ? 1 : 0;
            }
        }
        return new BitMatrix(Rows, Columns, values);
    }

    public static bool TryParse(string s, out BitMatrix result)
    {
        if (s == null || s.Length == 0)
        {
            result = null;
            return false;
        }

        var lengths = s.Split(new[] { Environment.NewLine, " " }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 1; i < lengths.Length; i++)
        {
            if (lengths[i - 1].Length != lengths[i].Length)
            {
                result = null;
                return false;
            }
        }
        int Columns = lengths[0].Length;
        int Rows = lengths.Length;
        int[] values = new int[Columns * Rows];

        for (int i = 0, k = 0; i < lengths.Length; i++)
        {
            for (int j = 0; j < lengths[i].Length; j++, k++)
            {
                if (lengths[i][j] != '0' && lengths[i][j] != '1')
                {
                    result = null;
                    return false;
                }

                values[k] = lengths[i][j] == '1' ? 1 : 0;
            }
        }
        result = new BitMatrix(Rows, Columns, values);
        return true;
    }

}

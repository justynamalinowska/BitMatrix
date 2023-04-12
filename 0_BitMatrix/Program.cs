using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitMatrixNameSpace;

    public class Program
    {
        public void Main(string[] args)
        {
            var m = new BitMatrix(2, 2, new int[] { 1, 0, 0, 1 });
            Console.WriteLine(m);

            m = new BitMatrix(2, 2, 1, 0, 0, 0);
            Console.WriteLine(m);

        }
    }


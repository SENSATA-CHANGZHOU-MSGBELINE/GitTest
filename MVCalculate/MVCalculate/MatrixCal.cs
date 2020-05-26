using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCalculate
{
    public static class MatrixCal
    {
        public static double[,] MatrixTimes (double[,] m1, double[,] m2)
        {
            int imax = m1.GetLength(0);
            int jmax = m1.GetLength(1);
            double[,] m3 = new double[imax,jmax];

            if (m1.GetLength(1) == m2.GetLength(1)&&m2.GetLength(0) == 1)
            {
                for (int i=0; i<m1.GetLength(1); i++)
                {
                    for (int j =0; j<m1.GetLength(0); j++)
                    {
                        m3[i, j] = m1[i, j] * m2[0, i];
                    }
                }
            }

            return m3;            
        }

        public static double MatrixSumTimes(double[,] m1, double[,] m2)
        {
            double p = 0.0;
            if (m1.GetLength(1) == m2.GetLength(1) && m2.GetLength(0) == 1)
            {
                for (int i = 0; i < m1.GetLength(0); i++)
                {
                    double p1 = 0;
                    for (int j = 0; j < m1.GetLength(1); j++)
                    {
                        p1 += m1[j, i];
                    }

                    p += p1 * m2[0, i];
                }
            }

            return p;
        }
    }
}

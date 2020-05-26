using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace MVCalculate
{
    static class DataTableCalculate
    {
        public static DataTable DataTableMultiply (DataTable dt1, DataTable dt2)
        {
            if (dt1.Rows.Count != dt2.Rows.Count)
            {
                MessageBox.Show("rows not equal");
            }

            if (dt2.Columns.Count != 1)
            {
                MessageBox.Show("Second table has more collumes");
            }

            DataTable dt3 = dt1.Clone();

            for (int i =0; i<dt1.Rows.Count; i++)
            {
                for (int j=0; j<dt1.Columns.Count; j++)
                {
                    dt3.Rows[i][j] = Convert.ToDouble(dt1.Rows[i][j]) * Convert.ToDouble(dt2.Rows[i][0]);
                }
            }

            return dt3;
        }

        public static double DataTableSumMultiply(DataTable dt1, DataTable dt2)
        {
            double p = 0.0;
            for (int i = 0; i < dt1.Columns.Count; i++)
            {
                for (int j = 0; j<dt1.Rows.Count; j++)
                {
                    p += Convert.ToDouble(dt1.Rows[j][i]);
                }

                p *= Convert.ToDouble(dt2.Rows[i][0]);
            }

            return p;
        }

    }
}

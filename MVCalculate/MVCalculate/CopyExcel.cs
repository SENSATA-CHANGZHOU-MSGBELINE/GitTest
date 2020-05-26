using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCalculate
{
    static class CopyExcel
    {
        static public int Paste(DataGridView dgv)
        {
            string sTotal = Clipboard.GetText();

            string[] sLine = sTotal.Split('\n');

            foreach (string sOneLine in sLine)
            {
                string[] sCell = sOneLine.Split('\t');
                //if (sCell.Length != dgv.ColumnCount && sCell.Length != 1)
                //{
                //    MessageBox.Show("Collums not corret");
                //    return 1;
                //}
                //else 
                if (sCell.Length == 1)
                {
                    string sp = "In total " + (sLine.Length - 1) + " lines added";
                    MessageBox.Show(sp);
                    break;
                }
                else
                {
                    dgv.Rows.Add(sCell);
                }
            }

            return 0;
        }

    }
}

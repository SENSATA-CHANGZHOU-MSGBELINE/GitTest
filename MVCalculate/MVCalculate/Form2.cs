using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCalculate
{
    public partial class f123 : Form
    {
        public f123()
        {
            InitializeComponent();
        }

        private void f123_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }

        SQLComm s = new SQLComm();
        f123Limits f2 = new f123Limits();

        

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RightClik.Show(MousePosition);
            }
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyExcel.Paste(Data);
        }

        private void clearTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.AllowUserToAddRows = true;
            Data.Rows.Clear();
        }

        private void bcmv_Click(object sender, EventArgs e)
        {
            
            s.getMVtable123(tbDeviceID.Text);
            s.getCenter123(tbDeviceID.Text);

            int i1 = s.ds.Tables["MVL"].Rows.Count;
            int i2 = s.ds.Tables["MVL"].Columns.Count - 1;
            double[,] m1 = new double[i1, i2];

            for (int i = 0; i < i1; i++)
            {
                for (int j=0; j<i2; j++)
                {
                    m1[i, j] = Convert.ToDouble(s.ds.Tables["MVL"].Rows[i][j + 1]);
                }
            }

            foreach (DataGridViewRow dr in Data.Rows)
            {
                if(dr.Cells[0].Value != null)
                {
                    double[,] m2 = new double[1, 2];
                    m2[0, 0] = (Convert.ToDouble(dr.Cells[1].Value) - Convert.ToDouble(s.ds.Tables["Center"].Rows[0][1])) / Convert.ToDouble(s.ds.Tables["Center"].Rows[0][3]);
                    m2[0, 1] = (Convert.ToDouble(dr.Cells[2].Value) - Convert.ToDouble(s.ds.Tables["Center"].Rows[0][2])) / Convert.ToDouble(s.ds.Tables["Center"].Rows[0][4]);

                    dr.Cells[3].Value = MatrixCal.MatrixSumTimes(MatrixCal.MatrixTimes(m1, m2), m2);
                }
            }

            Data.AllowUserToAddRows = false;
            Data.Update();
        }

        private void bcheckLimits_Click(object sender, EventArgs e)
        {
            if (tbDeviceID.Text.Length <1)
            {
                MessageBox.Show("Please key in deviceID");

            }
            else
            {
                commWork.deviceID = tbDeviceID.Text;
                     
                f123Limits f = new f123Limits();
                f.Show();
            }

        }
    }

    public static class commWork
    {
        public static string deviceID { get; set; }
    }
}

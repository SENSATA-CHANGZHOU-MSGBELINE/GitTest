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
    public partial class f123Limits : Form
    {
        public f123Limits()
        {
            InitializeComponent();
        }

        private void bGetLimts_Click(object sender, EventArgs e)
        {
            SQLComm s = new SQLComm();
            dgCenter.DataSource = s.getCenter123(commWork.deviceID);
            dgMVL.DataSource = s.getMVtable123(commWork.deviceID);
        }
    }
}

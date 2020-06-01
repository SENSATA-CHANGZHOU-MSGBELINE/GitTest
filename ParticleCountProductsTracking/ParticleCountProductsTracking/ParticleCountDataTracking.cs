using System;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Collections;

namespace ParticleCountProductsTracking
{
    public partial class ParticleCountDataTracking : Form
    {
        SerialPort SerialPort;
        public String ReadValue;

        public ParticleCountDataTracking()
        {
            InitializeComponent();
            InitPort();
            DeviceIDFill();
        }

        void InitPort()
        {
            try
            {
                SerialPort = new SerialPort("COM4", 9600, Parity.None);
                SerialPort.DataReceived += SerialPort_DataReceived;
                SerialPort.ReceivedBytesThreshold = 1;
                SerialPort.Encoding = Encoding.Default;
                SerialPort.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("COM port open failed: " + e.Message);
            }
        }

        void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(100);
            byte[] data = new byte[SerialPort.BytesToRead];
            SerialPort.Read(data, 0, SerialPort.BytesToRead);
            ReadValue = Encoding.Default.GetString(data);



            this.Invoke((EventHandler)delegate
            {
                if (lbReadResult.Text.Length < 5)
                {
                    lbReadResult.Text = "扫描结果：" + "请重新扫描！";
                    lbScanStatus.Text = "NG";
                    lbScanStatus.BackColor = Color.OrangeRed;
                }
                else
                {
                    if (true)
                    {

                    }
                    lbReadResult.Text = "扫描结果：" + ReadValue;
                    lbScanStatus.Text = "OK";
                    lbScanStatus.BackColor = Color.LimeGreen;

                }
            });
        }

        //DatabaeCheck DatabaeCheck = new DatabaeCheck();

        private void ParticleCountDataTracking_Load(object sender, EventArgs e)
        {

            lbScanStatus.Text = "Ready";


        }


        /// <summary>
        /// 连接数据库，并读取DeviceID赋值给comBox
        /// </summary>
        private void DeviceIDFill()
        {

            string deviceid = "deviceid";
            string database = "msgreportingcz.dbo.msgdeviceids";
            string sqlServerInfo = "Data Source = MSGReportingCZ;Initial Catalog=MSGReportingCZ;Integrated Security=True";
            string SqlStatement = "select " + deviceid + " from " + database;


            using (SqlConnection sqlConnection = new SqlConnection(sqlServerInfo))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand(SqlStatement, sqlConnection);
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {

                        comboxDeviceID.Items.Add(dataReader["DeviceID"].ToString());
                    }
                    dataReader.Close();
                }
                catch (SqlException sqlE)
                {

                    MessageBox.Show("Data base connection error:" + sqlE.Message);

                }
            }
        }
    }
}

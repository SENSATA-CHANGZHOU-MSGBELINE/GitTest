using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ParticleCountProductsTracking
{
    public static class SQLGetResults
    {
        static string connectionString = @"Server= sczpdb13; Database= MSGProductionMasterCZ; Integrated Security=SSPI";
        static SqlConnection connection = new SqlConnection(connectionString);

        public static DeviceInfor GetDeviceinfor (string housingCode)
        {
            DeviceInfor device = new DeviceInfor();
            device.housingCode = housingCode;

            string getSN = "select serialno from msgreportingcz.dbo.msghousingCodeHistory (nolock) where housing code = '" + housingCode + "'";

            device.serialNo = Convert.ToInt32(GetDBReply(getSN).Tables[0].Rows[0][0]);

            string getT1Fix = "select top 1 fixture from msg12123calibhistory (nolock) where testtime > '2019-1-1' and mode = 'T1cal' and serialno = " + device.serialNo + " order by testtime desc";
            device.T1fixture = Convert.ToInt32(GetDBReply(getT1Fix).Tables[0].Rows[0][0]);

            string getT2Fix = "select top 1 fixture from msg12123calibhistory (nolock) where testtime > '2019-1-1' and mode = 'T2cal' and serialno = " + device.serialNo + " order by testtime desc";
            device.T2fixture = Convert.ToInt32(GetDBReply(getT2Fix).Tables[0].Rows[0][0]);

            string getT3Fix = "select top 1 fixture from msg12123calibhistory (nolock) where testtime > '2019-1-1' and mode = 'T3cal' and serialno = " + device.serialNo + " order by testtime desc";
            device.T3fixture = Convert.ToInt32(GetDBReply(getT3Fix).Tables[0].Rows[0][0]);

            string getT4Fix = "select top 1 fixture from msg12123calibhistory (nolock) where testtime > '2019-1-1' and mode = 'T4cal' and serialno = " + device.serialNo + " order by testtime desc";
            device.T4fixture = Convert.ToInt32(GetDBReply(getT4Fix).Tables[0].Rows[0][0]);

            return device;
        }

        private static DataSet GetDBReply (string commond)
        {
            SqlCommand sc = new SqlCommand();
            sc.Connection = connection;

            SqlDataAdapter sa = new SqlDataAdapter();
            sa.SelectCommand = sc;
            sc.CommandText = commond;

            DataSet ds = new DataSet();

            using (connection)
            {
                sa.Fill(ds);
            }
            return ds;
        }
    }

    public struct DeviceInfor
    {
        public string housingCode;
        public int serialNo;
        public int T1fixture;
        public int T2fixture;
        public int T3fixture;
        public int T4fixture;
    }
}

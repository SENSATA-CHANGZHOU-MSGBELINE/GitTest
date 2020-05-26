using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MVCalculate
{
    public class SQLComm
    {
        private static string connetionSettings = @"Server= sczpdb13; Database= MSGProductionMasterCZ; Integrated Security=SSPI";

        //private static SqlConnection con = new SqlConnection(s);

        public DataSet ds = new DataSet();


        //get ellipose parameter 
        public DataTable getMVtable123 (string deviceID)
        {
            SqlConnection con = new SqlConnection(connetionSettings);
            ds.Tables.Add("MVL");
            DataTable dt = ds.Tables["MVL"];
            
            StringBuilder sb = new StringBuilder();
            sb.Append(@"SELECT [row], [1], [2] FROM (SELECT [row],[Col],[value] FROM dbo.MSG12123MultivariantSPCInvCovarianceMatrix WHERE DeviceID = '");
            sb.Append(deviceID);
            sb.Append(@"') AS SourceTable PIVOT(AVG([value]) FOR[Col] IN([1], [2])) AS PivotTable");

            string s = sb.ToString();

            SqlCommand sc = new SqlCommand();
            sc.Connection = con;
            sc.CommandType = CommandType.Text;
            sc.CommandText = s;

            SqlDataAdapter sa = new SqlDataAdapter(sc);


            using (con)
            {
                con.Open();
                sa.Fill(dt);
            }

            return dt;
        }

        public DataTable getCenter123(string deviceID)
        {
            SqlConnection con = new SqlConnection(connetionSettings);
            ds.Tables.Add("Center");
            DataTable dt = ds.Tables["Center"];

            StringBuilder sb = new StringBuilder();
            sb.Append(@"SELECT * FROM [MSGProductionMasterCZ].[dbo].[MSG12123StatisticalInputsLimits] WHERE DeviceID = '");
            sb.Append(deviceID);
            sb.Append(@"'");

            string s = sb.ToString();

            SqlCommand sc = new SqlCommand();
            sc.Connection = con;
            sc.CommandType = CommandType.Text;
            sc.CommandText = s;

            SqlDataAdapter sa = new SqlDataAdapter(sc);


            using (con)
            {
                con.Open();
                sa.Fill(dt);
            }

            return dt;
        }
    }
}

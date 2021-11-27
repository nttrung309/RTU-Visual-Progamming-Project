using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace RoadToUni.Forms.Search.FindSchool
{
    class ClassCrud
    {
        SqlCeConnection con = new SqlCeConnection($@"Data Source={Application.StartupPath}\Data\Database\RTU.sdf");
        private void OpenConnect()
        {
            if(con.State ==ConnectionState.Closed)
            {
                con.Open();
            }    
        }
        private void CloseConnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public Boolean ExceData(string cmd)
        {
            OpenConnect();
            Boolean check = false;
            try
            {
                SqlCeCommand cmds = new SqlCeCommand(cmd, con);
                cmds.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            CloseConnect();
            return check;
        }
        public DataTable ReadData (string cmd)
        {
            OpenConnect();
            DataTable dt = new DataTable();
            try
            {
                SqlCeCommand cmds = new SqlCeCommand(cmd, con);
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmds);
                da.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            CloseConnect();
            return dt;
        }

    }
}

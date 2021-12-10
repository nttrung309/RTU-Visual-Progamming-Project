using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChoosingMajor
{
    public partial class SecondUI : Form
    {
        public static string Nhomnganh = string.Empty;
        public SecondUI(string nhomnganh)
        {
             Nhomnganh= nhomnganh;

            InitializeComponent();
            var pos = this.PointToScreen(lblTitle.Location);
            pos = pbxTitle.PointToClient(pos);
            lblTitle.Parent = pbxTitle;
            lblTitle.Location = pos;
        }

        private void SecondUI_Load(object sender, EventArgs e)
        {
            this.fpnlNganh.Controls.Clear();
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT NGANHCHUNG.TENNGANHCHUNG FROM NGANHCHUNG, NHOMNGANH WHERE NGANHCHUNG.MANHNGANH = NHOMNGANH.MANHNGANH AND TENNHNGANH = N'" + Nhomnganh + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    JobTile jtile = new JobTile();
                    jtile.Job = row["TENNGANHCHUNG"].ToString();
                    jtile.Name = row["TENNGANHCHUNG"].ToString();
                    this.fpnlNganh.Controls.Add(jtile);
                }
                con.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}

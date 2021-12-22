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
using System.Data.SqlServerCe;

namespace RoadToUni.Forms.MBTI.Link
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
            using (SqlCeConnection con = new SqlCeConnection(RoadToUni.Forms.Search.Major.ChoosingMajor.ConnectionString.connectionString))
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("SELECT NGANHCHUNG.TENNGANHCHUNG FROM NGANHCHUNG, NHOMNGANH WHERE NGANHCHUNG.MANHNGANH = NHOMNGANH.MANHNGANH AND TENNHNGANH = N'" + Nhomnganh + "'", con);
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    RoadToUni.Forms.MBTI.Link.JobTile jtile = new RoadToUni.Forms.MBTI.Link.JobTile();
                    jtile.Job = row["TENNGANHCHUNG"].ToString();
                    jtile.Name = row["TENNGANHCHUNG"].ToString();
                    this.fpnlNganh.Controls.Add(jtile);
                }
                con.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Đồ_án_1.Meow.PopForm();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}

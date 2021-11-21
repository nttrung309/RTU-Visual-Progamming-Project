using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        ClassCrud crud = new ClassCrud();
        string idUni = null;
        string nameUni = null;
        string major = null;
        string bench = null;
        float grade;
        public Form2(string idUni,string nameUni, string major, string bench, float grade): this()
        {
            this.idUni = idUni;
            this.major = major;
            this.bench = bench;
            this.grade = grade;
            this.nameUni = nameUni;
        }
        DataTable LoadDB()
        {
            DataTable dt = new DataTable();
            DataTable dtCol = new DataTable();
            dtCol.Columns.Add("STT");
            string query;
            if (major == "Tất cả các ngành")
            {
                query = "SELECT XET.MANGANH, NGANH.TENNGANH, XET.DIEMCHUAN " +
                        "FROM TRUONG, XET, NGANH " +
                        "WHERE TRUONG.MATRUONG = XET.MATRUONG " +
                        "AND NGANH.MANGANH = XET.MANGANH " +
                        "AND TRUONG.MATRUONG = '" + idUni + "'" +
                        "AND NAM = 2021 " +
                        "AND CHUOITOHOP LIKE '%" + bench + "%' " +
                        "AND DIEMCHUAN <=" + grade +
                        "ORDER BY DIEMCHUAN DESC";
            }
            else
            {
                query = "SELECT XET.MANGANH, NGANH.TENNGANH, XET.DIEMCHUAN " +
                        "FROM TRUONG, XET, NGANH " +
                        "WHERE TRUONG.MATRUONG = XET.MATRUONG " +
                        "AND NGANH.MANGANH = XET.MANGANH " +
                        "AND TRUONG.MATRUONG = '" + idUni + "'" +
                        "AND NAM = 2021 " +
                        "AND CHUOITOHOP LIKE '%" + bench + "%' " +
                        "AND DIEMCHUAN <=" + grade +
                        "AND EXISTS( " +
                        "SELECT * FROM NGANHCHUNG, NHOMNGANH " +
                        "WHERE TENNGANH LIKE '%' + TENNGANHCHUNG + '%' " +
                        "AND NGANHCHUNG.MANHNGANH = NHOMNGANH.MANHNGANH " +
                        "AND TENNHNGANH = N'" + major + "') " +
                        "ORDER BY DIEMCHUAN DESC";
            }
            dt = crud.ReadData(query);
            dtCol.Merge(dt);
            return dtCol;
        }
        private void DisableClickHeader()
        {
            foreach (DataGridViewColumn column in dgvShow.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void SetColName()
        {

            dgvShow.RowHeadersVisible = false;
            dgvShow.EnableHeadersVisualStyles = false;
            dgvShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvShow.ClearSelection();
            dgvShow.ColumnHeadersHeight = 35;
            dgvShow.ColumnHeadersDefaultCellStyle.BackColor = Color.PaleGreen;
            dgvShow.Columns[1].HeaderText = "Mã ngành";
            dgvShow.Columns[2].HeaderText = "Tên ngành";
            dgvShow.Columns[3].HeaderText = "điểm chuẩn 2021";

            foreach (DataGridViewColumn col in dgvShow.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }
       
        private void SetColorRowDT()
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            style1.BackColor = Color.Yellow;
            style2.BackColor = Color.LightCyan;
            for (int i = dgvShow.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                    dgvShow.Rows[i].DefaultCellStyle = style1;
                else
                    dgvShow.Rows[i].DefaultCellStyle = style2;
            }
        }
        private void SetSizeCol()
        {
            dgvShow.Columns[0].Width = 30;
            dgvShow.Columns[1].Width = 60;
            dgvShow.Columns[2].Width = 175;
            dgvShow.Columns[3].Width = 100;
        }
        private void SetMiddleCol()
        {
            dgvShow.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvShow.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dgvShow.DataSource = this.LoadDB();
            string bm = idUni + ".jpg";
            SetColName();
            SetColorRowDT();
            DisableClickHeader();
            SetSizeCol();
            SetMiddleCol();
            
            lbNameUni.Text = nameUni;
            lbMajor.Text = major;
            pictureBox1.BackgroundImage = new Bitmap(Application.StartupPath + "\\Images\\LogoUni\\" + bm);
            for (int i = 0; i < dgvShow.Rows.Count; i++)
            {
                dgvShow.Rows[i].Cells[0].Value = i + 1;
            }
            int totalRowHeight = dgvShow.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgvShow.Rows)
                totalRowHeight += row.Height;
            if (totalRowHeight < 200)
                dgvShow.Height = totalRowHeight; 
            else
                dgvShow.Height = 200;
        }
    }
}

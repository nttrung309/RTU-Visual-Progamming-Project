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
    public partial class fsearch : Form
    {
        ClassCrud crud = new ClassCrud();
        public fsearch()
        {
            InitializeComponent();
            LoadNameMajor();
            
            
        }
        void LoadNameMajor()
        {
            DataTable dt = new DataTable();
            dt = crud.ReadData("SELECT * FROM NHOMNGANH");
            //dt.Columns.Add("NameAndID", typeof(string), "MATRUONG + ' - '+ TENTRUONG");
            //object[] arr = { "Tất cả các trường", "", "" };
           // dt.Rows.Add(arr);
            cbNameUni.DisplayMember = "TENNHNGANH";
            cbNameUni.DataSource = dt;
            cbNameUni.SelectedIndex = -1;
            cbNameUni.Text = "Chọn ngành/nhóm ngành";
        }
        bool IsNumeric(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbNameUni.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbGrade.Text.Equals("Điểm xét tuyển dự kiến"))
            {
                MessageBox.Show("Vui lòng nhập số điểm dự kiến", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsNumeric(txbGrade.Text))
            {
                MessageBox.Show("Vui lòng chỉ nhập ký tự số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.Parse(txbGrade.Text) <= 0)
            {
                MessageBox.Show("Vui lòng nhập số điểm lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.Parse(txbGrade.Text) > 40)
            {
                MessageBox.Show("Điểm xét tuyển tối đa 40! Vui lòng nhập số điểm nhỏ hơn 40", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if(cbCombination.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tổ hợp xét tuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            dataGridViewResult.DataSource = this.LoadDB();
            SetColName();
            SetWidthDataTable();
            SetColorRowDT();
            DisableClickHeader();
            SetMiddleCol();
            for (int i = 0; i < dataGridViewResult.Rows.Count ; i++)
            {
                dataGridViewResult.Rows[i].Cells[0].Value = i + 1;
            }
            CheckResult();
            int totalRowHeight = dataGridViewResult.ColumnHeadersHeight;

            foreach (DataGridViewRow row in dataGridViewResult.Rows)
                totalRowHeight += row.Height;
            if (totalRowHeight < 350)
                dataGridViewResult.Height = totalRowHeight;
            else
                dataGridViewResult.Height = 350;

            

        }
        DataTable LoadDB()
        {
            DataTable dt = new DataTable();
            DataTable dtCol = new DataTable();
            dtCol.Columns.Add("STT");
            string nameMajors = cbNameUni.GetItemText(cbNameUni.SelectedItem);
            //string IDUni = nameAndID.Substring(0, 3);
            //if(IDUni.Equals("Tất"))
            //{
            //    IDUni = "";
            //}    
            //string subjectComb = cbCombination.GetItemText(cbCombination.SelectedItem);
            //string comb = subjectComb.Substring(0, 3);
            //float mark = float.Parse(txbGrade.Text);

            //string query = "SELECT XET.MATRUONG, TENTRUONG, XET.MANGANH,NGANH.TENNGANH, DIEMCHUAN " +
            //               "FROM XET, TRUONG, NGANH " +
            //               "WHERE  XET.MATRUONG = TRUONG.MATRUONG AND " +
            //               "XET.MANGANH = NGANH.MANGANH AND " +
            //               "XET.MATRUONG LIKE '%" + IDUni + "%' AND " +
            //               "XET.NAM = 2021 AND " +
            //               "XET.CHUOITOHOP LIKE '%" + comb + "%' AND " +
            //               "DIEMCHUAN <= " + mark + "ORDER BY XET.MATRUONG, DIEMCHUAN DESC";
            //dt = crud.ReadData(query);
            string subjectComb = cbCombination.GetItemText(cbCombination.SelectedItem);
            string comb = subjectComb.Substring(0, 3);
            float mark = float.Parse(txbGrade.Text);
            //string query =  "SELECT TRUONG.MATRUONG, TENTRUONG, COUNT(NGANH.MANGANH) AS KETQUA " +
            //                 "FROM TRUONG, XET, NGANH " +
            //                 "WHERE TRUONG.MATRUONG = XET.MATRUONG" +
            //                 "AND NGANH.MANGANH = XET.MANGANH " +
            //                 "AND NAM = 2021 " +
            //                 "AND XET.CHUOITOHOP LIKE '%" + comb + "%'" +
            //                 "AND DIEMCHUAN <= " + mark +
            //                 "AND EXISTS(" +
            //                 "SELECT * FROM NGANHCHUNG, NHOMNGANH " +
            //                 "WHERE TENNGANH LIKE '%' + TENNGANHCHUNG + '%' " +
            //                 "AND NGANHCHUNG.MANHNGANH = NHOMNGANH.MANHNGANH" +
            //                 "AND TENNHNGANH = N'" + nameMajors + "')" +
            //                 "GROUP BY TRUONG.MATRUONG, TENTRUONG " +
            //                 "ORDER BY KETQUA DESC";
            string query = "SELECT TRUONG.MATRUONG, TENTRUONG,COUNT(NGANH.MANGANH) AS KETQUA " +
                        "FROM TRUONG, XET, NGANH " +
                        "WHERE TRUONG.MATRUONG = XET.MATRUONG " +
                        "AND NGANH.MANGANH = XET.MANGANH " +
                        "AND NAM = 2021 " +
                        "AND CHUOITOHOP LIKE '%"+comb+"%' " +
                        "AND DIEMCHUAN <="+mark +
                        "AND EXISTS( " +
                        "SELECT * FROM NGANHCHUNG, NHOMNGANH " +
                        "WHERE TENNGANH LIKE '%' + TENNGANHCHUNG + '%' " +
                        "AND NGANHCHUNG.MANHNGANH = NHOMNGANH.MANHNGANH " +
                        "AND TENNHNGANH = N'"+nameMajors+"') " +
                        "GROUP BY TRUONG.MATRUONG, TENTRUONG " +
                        "ORDER BY KETQUA DESC";
            dt = crud.ReadData(query);
            dtCol.Merge(dt);
            return dtCol;
        }
        private void SetWidthDataTable()
        {
            dataGridViewResult.Columns[0].Width = 30;
            dataGridViewResult.Columns[1].Width = 60;
            dataGridViewResult.Columns[2].Width = 280;
            dataGridViewResult.Columns[3].Width = 100;
            //dataGridViewResult.Columns[4].Width = 350;
            //dataGridViewResult.Columns[5].Width = 100;

          
        }
        private void DisableClickHeader()
        {
            foreach (DataGridViewColumn column in dataGridViewResult.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void SetColorRowDT()
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            style1.BackColor = Color.LemonChiffon;
            style2.BackColor = Color.LightCyan;
            for (int i = dataGridViewResult.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) 
                    dataGridViewResult.Rows[i].DefaultCellStyle = style1;
                else
                    dataGridViewResult.Rows[i].DefaultCellStyle = style2;
            }
        }
        private void SetColName()
        {
           
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.EnableHeadersVisualStyles = false;
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewResult.ClearSelection();
            dataGridViewResult.ColumnHeadersHeight = 35;
            dataGridViewResult.ColumnHeadersDefaultCellStyle.BackColor = Color.PaleGreen;
            dataGridViewResult.Columns[1].HeaderText= "Mã trường";
            dataGridViewResult.Columns[2].HeaderText = "Tên trường";
            dataGridViewResult.Columns[3].HeaderText= "Kết quả";
            //dataGridViewResult.Columns[4].HeaderText = "Tên ngành";
            //dataGridViewResult.Columns[5].HeaderText = "Điểm chuẩn";
            foreach (DataGridViewColumn col in dataGridViewResult.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            
        }
        private void CheckResult()
        {
            string nameAndID = cbNameUni.GetItemText(cbNameUni.SelectedItem);
            string IDUni = nameAndID.Substring(0, 3);   
            if(dataGridViewResult.Rows.Count == 0)
            {
                MessageBox.Show(String.Format("Không có ngành nào thuộc nhóm ngành {0} có điểm chuẩn nhỏ hơn điểm dự kiến của bạn",nameAndID),"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }  
        }

        private void txbGrade_Enter(object sender, EventArgs e)
        {
            if (txbGrade.Text == "Điểm xét tuyển dự kiến")
            {
                txbGrade.Text = "";
                txbGrade.ForeColor = Color.Black;
            }
        }

        private void txbGrade_Leave(object sender, EventArgs e)
        {
            if (txbGrade.Text == "")
            {
                txbGrade.Text = "Điểm xét tuyển dự kiến";
                txbGrade.ForeColor = Color.DarkGray;
            }
        }

        private void cbCombination_Enter(object sender, EventArgs e)
        {
            if(cbCombination.Text == "Chọn tổ hợp xét tuyển")
            {
                cbCombination.Text = "";
                cbCombination.ForeColor = Color.Black;
            }    
        }

        private void cbCombination_Leave(object sender, EventArgs e)
        {
            if (cbCombination.Text == "")
            {
                cbCombination.Text = "Chọn tổ hợp xét tuyển";
                cbCombination.ForeColor = Color.DarkGray;
            }
        }

        private void cbNameUni_Enter(object sender, EventArgs e)
        {
            if (cbNameUni.Text == "Chọn ngành/nhóm ngành") ;
            {
                cbNameUni.Text = "";
                cbNameUni.ForeColor = Color.Black;
            }
        }
        //private int dgvHeight()
        //{
        //    int sum = this.dataGridViewResult.ColumnHeadersHeight;

        //    foreach (DataGridViewRow row in this.dataGridViewResult.Rows)
        //        sum += row.Height + 1; // I dont think the height property includes the cell border size, so + 1

        //    return sum;
        //}
        private int dgvHeight()
        {
            int sum = this.dataGridViewResult.ColumnHeadersHeight;

            foreach (DataGridViewRow row in this.dataGridViewResult.Rows)
                sum += row.Height + 1; // I dont think the height property includes the cell border size, so + 1

            return sum;
        }
        private void cbNameUni_Leave(object sender, EventArgs e)
        {
            if (cbNameUni.Text == "")
            { 
                cbNameUni.Text = "Chọn ngành/nhóm ngành";
                cbNameUni.ForeColor = Color.DarkGray;
            }
        }
        private void SetMiddleCol()
        {
            dataGridViewResult.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewResult.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewResult.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dataGridViewResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idUni = dataGridViewResult.Rows[e.RowIndex].Cells[1].Value.ToString();
            string nameUni = dataGridViewResult.Rows[e.RowIndex].Cells[2].Value.ToString();
            string major = cbNameUni.Text;
            string subjectComb = cbCombination.GetItemText(cbCombination.SelectedItem);
            string comb = subjectComb.Substring(0, 3);
            float grade = float.Parse(txbGrade.Text);
            Form2 f2 = new Form2(idUni,nameUni, major, comb, grade);
            f2.Show();
        }

    }
}

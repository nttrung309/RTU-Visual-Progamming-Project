using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadToUni.Forms.Search.FindSchool
{
    public partial class fFindSchool : Form
    {
        ClassCrud crud = new ClassCrud();
        public fFindSchool()
        {
            InitializeComponent();
            LoadNameUni();
            
            
        }
        void LoadNameUni()
        {
            DataTable dt = new DataTable();
            dt = crud.ReadData("SELECT * FROM TRUONG");
            dt.Columns.Add("NameAndID", typeof(string), "MATRUONG + ' - '+ TENTRUONG");
            object[] arr = { "Tất cả các trường", "", "" };
            dt.Rows.Add(arr);
            cbNameUni.DisplayMember = "NameAndID";
            cbNameUni.DataSource = dt;
            cbNameUni.SelectedIndex = -1;
            cbNameUni.Text = "Chọn trường";

        }
        bool IsNumeric(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }
        private void button1_Click(object sender, EventArgs e)
        {
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
            if (double.Parse(txbGrade.Text) > 32.75)
            {
                MessageBox.Show("Điểm xét tuyển tối đa 32.75! Vui lòng nhập số điểm nhỏ hơn 32.75", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cbNameUni.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            for (int i = 0; i < dataGridViewResult.Rows.Count - 1; i++)
            {
                dataGridViewResult.Rows[i].Cells[0].Value = i + 1;
            }
            CheckResult();



        }
        DataTable LoadDB()
        {
            DataTable dt = new DataTable();
            DataTable dtCol = new DataTable();
            dtCol.Columns.Add("STT");
            string nameAndID = cbNameUni.GetItemText(cbNameUni.SelectedItem);
            string IDUni = nameAndID.Substring(0, 3);
            if(IDUni.Equals("Tất"))
            {
                IDUni = "";
            }    
            string subjectComb = cbCombination.GetItemText(cbCombination.SelectedItem);
            string comb = subjectComb.Substring(0, 3);
            float mark = float.Parse(txbGrade.Text);

            string query = "SELECT XET.MATRUONG, TENTRUONG, XET.MANGANH,NGANH.TENNGANH, DIEMCHUAN " +
                           "FROM XET, TRUONG, NGANH " +
                           "WHERE  XET.MATRUONG = TRUONG.MATRUONG AND " +
                           "XET.MANGANH = NGANH.MANGANH AND " +
                           "XET.MATRUONG LIKE '%" + IDUni + "%' AND " +
                           "XET.NAM = 2021 AND " +
                           "XET.CHUOITOHOP LIKE '%" + comb + "%' AND " +
                           "DIEMCHUAN <= " + mark + "ORDER BY XET.MATRUONG, DIEMCHUAN DESC";
            dt = crud.ReadData(query);
            dtCol.Merge(dt);
            return dtCol;
        }
        private void SetWidthDataTable()
        {
            dataGridViewResult.Columns[0].Width = 45;
            dataGridViewResult.Columns[1].Width = 90;
            dataGridViewResult.Columns[2].Width = 280;
            dataGridViewResult.Columns[3].Width = 100;
            dataGridViewResult.Columns[4].Width = 350;
            dataGridViewResult.Columns[5].Width = 100;
          
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
            dataGridViewResult.Columns[3].HeaderText= "Mã ngành";
            dataGridViewResult.Columns[4].HeaderText = "Tên ngành";
            dataGridViewResult.Columns[5].HeaderText = "Điểm chuẩn";
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
            if (IDUni.Equals("Tất") && dataGridViewResult.Rows.Count == 1)
            {
                MessageBox.Show("Không có ngành nào của tất cả các Trường thuộc ĐHQG-TPHCM có điểm chuẩn nhỏ hơn điểm dự kiến của bạn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            if(!IDUni.Equals("Tất") && dataGridViewResult.Rows.Count == 1)
            {
                MessageBox.Show(String.Format("Không có ngành nào thuộc {0} có điểm chuẩn nhỏ hơn điểm dự kiến của bạn",nameAndID),"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (cbNameUni.Text == "Chọn trường")
            {
                cbNameUni.Text = "";
                cbNameUni.ForeColor = Color.Black;
            }
        }

        private void cbNameUni_Leave(object sender, EventArgs e)
        {
            if (cbNameUni.Text == "")
            {
                cbNameUni.Text = "Chọn trường";
                cbNameUni.ForeColor = Color.DarkGray;
            }
        }
    }
}

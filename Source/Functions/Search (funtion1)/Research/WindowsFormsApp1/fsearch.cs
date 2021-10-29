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
            LoadNameUni();
        }
        void LoadNameUni()
        {
            DataTable dt = new DataTable();
            
            dt = crud.ReadData("SELECT * FROM TRUONG");
            dt.Columns.Add(
                "NameAndID",
                 typeof(string),
                 "MATRUONG + ' - '+ TENTRUONG");
            object[] arr = {"Tất cả các trường","", ""};
            dt.Rows.Add(arr);
            cbNameUni.DisplayMember = "NameAndID";
            cbNameUni.DataSource = dt;
        }
        bool IsNumeric(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txbGrade.Text))
            {
                MessageBox.Show("Vui lòng nhập số điểm dự kiến", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (!IsNumeric(txbGrade.Text))
                {
                    MessageBox.Show("Vui lòng chỉ nhập ký tự số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (double.Parse(txbGrade.Text) > 30)
                    {
                        MessageBox.Show("Vui lòng nhập điểm nhỏ hơn 30", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dataGridViewResult.DataSource = this.GetAllBenchMarks();
                    }
                }
            }
           
        }
        DataTable GetAllBenchMarks()
        {
            DataTable dt = new DataTable();
            string nameAndID = cbNameUni.GetItemText(cbNameUni.SelectedItem);
            string ID = nameAndID.Substring(0, 3);
            if(ID.Equals("Tất"))
            {
                ID = "";
            }    
            string subjectComb = cbCombination.GetItemText(cbCombination.SelectedItem);
            string comb = subjectComb.Substring(0, 3);
            float mark = float.Parse(txbGrade.Text);
            string query = "SELECT TRUONG.MATRUONG, TRUONG.TENTRUONG, NGANH.MANGANH,NGANH.TENNGANH, XET.DIEMCHUAN FROM XET, TRUONG, NGANH WHERE  XET.MATRUONG = TRUONG.MATRUONG AND XET.MANGANH = NGANH.MANGANH AND XET.MATRUONG LIKE '%" + ID + "%' AND XET.NAM = 2021 AND XET.CHUOITOHOP LIKE '%" + comb + "%' AND DIEMCHUAN <= " + mark;
            dt = crud.ReadData(query);
            return dt;
        }
    }
}

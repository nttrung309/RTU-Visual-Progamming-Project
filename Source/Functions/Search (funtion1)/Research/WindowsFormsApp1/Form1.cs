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
    public partial class Form1 : Form
    {
        ClassCrud crud = new ClassCrud();
        public Form1()
        {
            InitializeComponent();
            LoadNameUni();
        }
        void LoadNameUni()
        {
            DataTable dt = new DataTable();
            
            dt = crud.ReadData("SELECT * FROM TRUONG");
            dt.Rows.Add("Tất cả các trường ĐHQG TPHCM");
            dt.Columns.Add(
                "NameAndID",
                 typeof(string),
                 "MATRUONG + ' - '+ TENTRUONG");
            comboBox1.DisplayMember = "NameAndID";
            comboBox1.DataSource = dt;
        }
         bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double mark;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập số điểm dự kiến", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                if (!IsNumber(textBox1.Text))
                {
                    MessageBox.Show("Vui lòng chỉ nhập ký tự số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(double.Parse(textBox1.Text) >30)
                    {
                        MessageBox.Show("Vui lòng nhập điểm nhỏ hơn 30", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                    else
                    {
                        dataGridView1.DataSource = this.GetAllBenchMarks();
                    }
                }
                
            }
            
        }
        DataTable GetAllBenchMarks()
        {
            DataTable dt = new DataTable();
            string nameAndID = comboBox1.GetItemText(comboBox1.SelectedItem);
            string ID = nameAndID.Substring(0, 3);
            string subjectComb = comboBox2.GetItemText(comboBox2.SelectedItem);
            string comb = subjectComb.Substring(0, 3);
            float mark = float.Parse(textBox1.Text);
            string query = "SELECT TRUONG.MATRUONG, TRUONG.TENTRUONG, NGANH.MANGANH,NGANH.TENNGANH, XET.DIEMCHUAN FROM XET, TRUONG, NGANH WHERE  XET.MATRUONG = TRUONG.MATRUONG AND XET.MANGANH = NGANH.MANGANH AND XET.MATRUONG = '" + ID + "' AND XET.NAM = 2021 AND XET.CHUOITOHOP LIKE '%" + comb + "%' AND DIEMCHUAN <= " + mark;
            dt = crud.ReadData(query);
            return dt;
        }
    }
}

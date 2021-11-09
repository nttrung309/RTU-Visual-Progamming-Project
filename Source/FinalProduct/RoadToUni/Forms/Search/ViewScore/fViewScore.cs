using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace RoadToUni.Forms.Search.ViewScore
{
   public partial class fViewScore : Form
    {
       
        SqlConnection connection;
        SqlCommand  command, command1, command2;
        DataTable table = new DataTable();
        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();
        DataTable tabe = new DataTable();
    
        string str = @"Data Source=TRUNGNGUYEN\SQLEXPRESS;Initial Catalog=databaseDiemChuan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        int i,count=0;
        void loaddata()
        {
//load dữ liệu từ Database
            command = connection.CreateCommand();
            command.CommandText = "select * from TRUONG";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            comboBox1.DataSource = table;
            comboBox1.ValueMember = "MATRUONG";
            comboBox1.DisplayMember = "TENTRUONG";
     

            // chọn trên trường các kiểu đã xong
            command1 = connection.CreateCommand();
            command1.CommandText = "select * from XET";
            adapter.SelectCommand = command1;
            table1.Clear();
            adapter.Fill(table1);
            //load data bảng Xét để tra
            command2 = connection.CreateCommand();
            command2.CommandText = "select * from NGANH";
            adapter.SelectCommand = command2;
            table2.Clear();
            adapter.Fill(table2);
            //Load data bảng Ngành để tra tên ngành luôn
            tabe.Columns.Add("STT");
            tabe.Columns.Add("Tên Ngành");
            tabe.Columns.Add("Mã Ngành");
            tabe.Columns.Add("Tổ Hợp");
            tabe.Columns.Add("Điểm");
            dataGridView1.DataSource = tabe;
        }
        public fViewScore()
        {
            InitializeComponent();
            noBackground();
            hideTheNextChap();
        }

       
        public void hideTheNextChap()
        {
// ẩn các control của trang thứ 2
            label1.Hide();
            comboBox1.Hide();
            label1.BackColor = Color.Transparent;
            label2.Hide();
            comboBox2.Hide();
            label2.BackColor = Color.Transparent;
           
            circlePicture4.Hide();
            groupBox2.Hide();
            
        }
        public void noBackground()
        {
// ẩn toàn bộ nền của các picture box
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
          
            circlePicture1.BackColor = Color.Transparent;
            circlePicture2.BackColor = Color.Transparent;
            circlePicture3.BackColor = Color.Transparent;
            circlePicture4.BackColor = Color.Transparent;
        }
       
            private void Form1_SizeChanged(object sender, EventArgs e)
            {
                // chỉnh lại vị trí và kích thước các control trong form khi thay đổi kích thước
 
                if (this.Width > 1110)
                {
                    dataGridView1.Columns[0].Width = 60 + 90;
                    dataGridView1.Columns[1].Width = 500 + 90;
                    dataGridView1.Columns[2].Width = 170 + 90;
                    dataGridView1.Columns[3].Width = 208 + 90;
                    dataGridView1.Columns[4].Width = 80 + 90;
                    dataGridView1.Font = new Font(" time new roman", 13.2f);
                }
                else
                {
                    dataGridView1.Columns[0].Width = 60;
                    dataGridView1.Columns[1].Width = 500;
                    dataGridView1.Columns[2].Width = 170;
                    dataGridView1.Columns[3].Width = 208;
                    dataGridView1.Columns[4].Width = 80;
                    dataGridView1.Font = new Font(" time new roman", 10.2f);
                }
        
                this.Show();
            }
        private void circlePicture1_Click_1(object sender, EventArgs e)
        {
            // chuyển chap
            comboBox1.SelectedIndex = -1;
            this.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            circlePicture1.Hide();
            label1.Show();
            comboBox1.Show();
            label2.Show();
            comboBox2.Show();

            circlePicture4.Show();
            this.Show();
        }

        private void circlePicture4_Click_1(object sender, EventArgs e)
        {
            // tra cứu ở đây
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin trước khi tra cứu");
            }
            else
            {
                groupBox2.Show();
                tabe.Clear();

                i = 0;
                while (table1.Rows[i].ItemArray[0].ToString() != comboBox1.SelectedValue.ToString())
                {
                    i++;

                }
                count = 0;

                while (i != table1.Rows.Count && table1.Rows[i].ItemArray[0].ToString() == comboBox1.SelectedValue.ToString())
                {


                    if (table1.Rows[i].ItemArray[3].ToString() == comboBox2.Text)
                    {

                        count++;
                        string[] a = new string[5];
                        a[0] = count.ToString();
                        a[2] = table1.Rows[i].ItemArray[1].ToString();
                        for (int j = 0; j < table2.Rows.Count; j++)
                        {
                            if (table2.Rows[j].ItemArray[0].ToString() == a[2])
                            {
                                a[1] = table2.Rows[j].ItemArray[1].ToString();
                                break;
                            }
                        }

                        a[3] = table1.Rows[i].ItemArray[2].ToString();
                        a[4] = table1.Rows[i].ItemArray[4].ToString();

                        tabe.Rows.Add(a);
                    }
                    i++;
                }



                dataGridView1.DataSource = tabe;
            }

        }

        private void circlePicture3_Click_1(object sender, EventArgs e)
        {
            // chuyển chap
            comboBox1.SelectedIndex = -1;
            this.Hide();
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            circlePicture1.Show();
            label1.Hide();
            comboBox1.Hide();
            label2.Hide();
            comboBox2.Hide();

            circlePicture4.Hide();
            groupBox2.Hide();
            this.Show();
        }

        private void circlePicture2_Click_1(object sender, EventArgs e)
        {
            fVSManual f = new fVSManual();
            f.Show();
            // mục hướng dẫn 
        }

      

      
        void dezignDataGridView()
        {
// điều chỉnh độ rộng cột cho datagrid
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 500;
            dataGridView1.Columns[2].Width = 170;
            dataGridView1.Columns[3].Width = 208;
            dataGridView1.Columns[4].Width = 80;
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            dezignDataGridView();
        }
    }
}

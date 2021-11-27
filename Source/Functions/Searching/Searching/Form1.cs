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
using System.Data.SqlServerCe;
namespace Searching
{
   public partial class Form1 : Form
    {     
  
        SqlCeConnection connection;
        SqlCeCommand  command, command1, command2,command3;
        DataTable table = new DataTable();
        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();
        DataTable table3 = new DataTable();
        DataTable tabe = new DataTable();
    
        string str = @"Data Source=C:\Users\Admin\Desktop\f\RTU.sdf";

        SqlCeDataAdapter adapter = new SqlCeDataAdapter();

        int i,count=0;
        void loaddata()
        {
            //load dữ liệu từ Database
        
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
        public Form1()
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
            label3.Hide();
            comboBox3.Hide();
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
            label3.BackColor = Color.Transparent;
        }
       
            private void Form1_SizeChanged(object sender, EventArgs e)
        {
// chỉnh lại vị trí và kích thước các control trong form khi thay đổi kích thước
            this.Hide();
            Thread.Sleep(500);
 
            if (this.WindowState == FormWindowState.Maximized)
            {
             
                this.pictureBox2.Location = new System.Drawing.Point(430, 80);
                    this.pictureBox3.Location = new System.Drawing.Point(900, 55);
                dataGridView1.Columns[0].Width = 60 + 90;
                dataGridView1.Columns[1].Width = 400 + 90;
                dataGridView1.Columns[2].Width = 110 + 90;
                dataGridView1.Columns[3].Width = 140 + 70;
                dataGridView1.Columns[4].Width = 60 + 70;
                dataGridView1.Font = new Font(" time new roman", 13.2f);


            }
            if (this.WindowState == FormWindowState.Normal)
            {

                this.pictureBox2.Location = new System.Drawing.Point(289, 64);
                this.pictureBox3.Location = new System.Drawing.Point(591, 57);
                dataGridView1.Columns[0].Width = 60;
                dataGridView1.Columns[1].Width = 400;
                dataGridView1.Columns[2].Width = 110;
                dataGridView1.Columns[3].Width = 140;
                dataGridView1.Columns[4].Width = 60;
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
            label3.Show();
            comboBox3.Show();
            circlePicture4.Show();
            this.Show();


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void circlePicture4_Click_1(object sender, EventArgs e)
        {
            // tra cứu ở đây
            chart1.Series["Biểu Đồ"].Points.Clear();
            this.chart1.Titles["Title1"].Text = "Biểu đồ giao động điểm";
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
              
                SetColorRowDT();
               
            }

        }

        private void circlePicture3_Click(object sender, EventArgs e)
        {

        }
        private void circlePicture2_Click_1(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            // mục hướng dẫn 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }



        void addColumn_Name()
        {

            command = connection.CreateCommand();
            command.CommandText = "select * from TRUONG";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            command = connection.CreateCommand();

            command.CommandText = "  ALTER TABLE TRUONG ADD NAME nvarchar(200) ";
            command.ExecuteNonQuery();


            int t = table.Rows.Count;

            for (int j = 0; j < t; j++)
            {
                command = connection.CreateCommand();

                command.CommandText = "update TRUONG set NAME=N'" + table.Rows[j].ItemArray[1].ToString() + " - " + table.Rows[j].ItemArray[0].ToString() + "' Where MATRUONG='" + table.Rows[j].ItemArray[0].ToString() + "' ";
                command.ExecuteNonQuery();
            }
        }
        private void SetColorRowDT()
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            style1.BackColor = Color.LemonChiffon;
            style2.BackColor = Color.LightCyan;
            for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LemonChiffon;
                else
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightCyan;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        void dezignDataGridView()
        {
            // điều chỉnh độ rộng cột cho datagrid
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 400;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Width = 140;
            dataGridView1.Columns[4].Width = 60;
       
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        void loadComboBoxCentralRegion()
        {
      

            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM [TRUONG] WHERE THUOCMIEN=N'Miền Trung'  ";
        
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            comboBox1.DataSource = table;
            comboBox1.ValueMember = "MATRUONG";
            comboBox1.DisplayMember = "NAME";
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Miền Trung")
                loadComboBoxCentralRegion();
            else
                if (comboBox3.Text == "Miền Nam")
                loadComboBoxSouth();
            else
                 if (comboBox3.Text == "Miền Bắc")
                loadComboBoxNorth();
            else
                loadComboBoxALL();
                

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "ALTER TABLE TRUONG DROP COLUMN NAME";
            command.ExecuteNonQuery();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        void loadComboBoxALL()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from TRUONG ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            comboBox1.DataSource = table;
            comboBox1.ValueMember = "MATRUONG";
            comboBox1.DisplayMember = "NAME";

        }

        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
           
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            command3 = connection.CreateCommand();

            command3.CommandText = "select * from XET";
            adapter.SelectCommand = command3;

            table3.Clear();
            adapter.Fill(table3);

            float a = 0, b = 0, c = 0;

            for (int j = 0; j < table3.Rows.Count; j++)
            {
                if (table3.Rows[j].ItemArray[0].ToString() == comboBox1.SelectedValue.ToString() && table3.Rows[j].ItemArray[3].ToString() == "2019" && table3.Rows[j].ItemArray[1].ToString() == dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString())
                {
                    a = float.Parse(table3.Rows[j].ItemArray[4].ToString());
                }
                if (table3.Rows[j].ItemArray[0].ToString() == comboBox1.SelectedValue.ToString() && table3.Rows[j].ItemArray[3].ToString() == "2020" && table3.Rows[j].ItemArray[1].ToString() == dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString())
                {
                    b = float.Parse(table3.Rows[j].ItemArray[4].ToString());
                }
                if (table3.Rows[j].ItemArray[0].ToString() == comboBox1.SelectedValue.ToString() && table3.Rows[j].ItemArray[3].ToString() == "2021" && table3.Rows[j].ItemArray[1].ToString() == dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString())
                {
                    c = float.Parse(table3.Rows[j].ItemArray[4].ToString());
                }
                if (a != 0 && b != 0 && c != 0)
                    break;
            }
            //   dataGridView1.DataSource = table3;
            //   int a = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].ToString());
            //   MessageBox.Show(a.ToString() + " " + b.ToString() + " " + c.ToString());

            //this.chart1.Titles.Clear();
            //chart1.Titles["Biểu Đồ"].Alignment = System.Drawing.ContentAlignment.TopLeft;
            //chart1.Titles["title1"].Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //chart1.Titles["title1"].ForeColor = System.Drawing.Color.DarkSlateGray;
            string st = "Ngành " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //this.chart1.Titles.Add(st);
            this.chart1.Titles["Title1"].Text = st;
            chart1.Series["Biểu Đồ"].Points.Clear();
            chart1.Series["Biểu Đồ"].Points.AddXY("2019", a);
            chart1.Series["Biểu Đồ"].Points[0].Label = a.ToString();
            chart1.Series["Biểu Đồ"].LabelForeColor = Color.Blue;
            //   chart1.Series["Biểu Đồ"].Points[0].Color = Color.Red;
            chart1.Series["Biểu Đồ"].Points.AddXY("2020", b);
            chart1.Series["Biểu Đồ"].Points[1].Label = b.ToString();
            chart1.Series["Biểu Đồ"].Points.AddXY("2021", c);
            chart1.Series["Biểu Đồ"].Points[2].Label = c.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }

        void loadComboBoxNorth()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from TRUONG Where THUOCMIEN=N'Miền Bắc'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            comboBox1.DataSource = table;
            comboBox1.ValueMember = "MATRUONG";
            comboBox1.DisplayMember = "NAME";
            comboBox1.SelectedIndex = -1;
        }
        void loadComboBoxSouth()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from TRUONG Where THUOCMIEN=N'Miền Nam'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            comboBox1.DataSource = table;
            comboBox1.ValueMember = "MATRUONG";
            comboBox1.DisplayMember = "NAME";
            comboBox1.SelectedIndex = -1;
        }
        private void Form1_Load(object sender, EventArgs e)
            
        {
            connection = new SqlCeConnection(str);
            connection.Open();
           addColumn_Name();
            loaddata();
            dezignDataGridView();
            
        }
       
    }
}

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

namespace Fuction4
{
    public partial class ThongtinNganh : Form
    {
        public string Code;
        public ThongtinNganh()
        {
            InitializeComponent();
        }

        string str = @"Data Source=desktop-puo8cb7\minhpham;Initial Catalog=databaseNew;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command, command1, command2, command3;
        DataTable table = new DataTable();
        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();
        DataTable table3 = new DataTable();
        DataTable tabe = new DataTable();

        SqlDataAdapter adapter = new SqlDataAdapter();

        int i, count = 0;

        private void ThongtinNganh_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            //addColumn_Name();
            TakeData(Code);
            dezignDataGridView();
        }

        void TakeData(string a)
        {
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

            tabe.Columns.Add("STT");
            tabe.Columns.Add("Tên Ngành");
            tabe.Columns.Add("Mã Ngành");
            tabe.Columns.Add("Tổ Hợp");
            //groupBox2.Show();
            tabe.Clear();

            i = 0;
            while ((table1.Rows[i].ItemArray[0].ToString() != a)/*&& (table1.Rows[i].ItemArray[4].ToString() == "2021")*/)
            {
                i++;
            }
            count = 0;

            while ((i != table1.Rows.Count) && (table1.Rows[i].ItemArray[0].ToString() == a)/*&& (table1.Rows[i].ItemArray[4].ToString() == "2021")*/)
            {
                    
                    string[] b = new string[4];
                //MessageBox.Show(table1.Rows[i].ItemArray[3].ToString());
                if (table1.Rows[i].ItemArray[3].ToString() == "2021")
                {
                    count++;
                    b[0] = count.ToString();
                    b[2] = table1.Rows[i].ItemArray[1].ToString();
                    for (int j = 0; j < table2.Rows.Count; j++)
                    {
                        if (table2.Rows[j].ItemArray[0].ToString() == b[2])
                        {
                            b[1] = table2.Rows[j].ItemArray[1].ToString();
                            break;
                        }
                    }
                    b[3] = table1.Rows[i].ItemArray[2].ToString();
                    tabe.Rows.Add(b);
                }
                    i++;
                
            }
            dataGridView1.DataSource = tabe;
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
        }
    }
}

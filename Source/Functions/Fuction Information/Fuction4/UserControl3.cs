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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }
        public string Code;
        string str = @"Data Source=D:\RTU.sdf";
        SqlCeConnection connection;
        SqlCeCommand command1, command2;
        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();
        DataTable tabble = new DataTable();
        SqlCeDataAdapter adapter = new SqlCeDataAdapter();
        int i, count = 0;
        public int y = 0;
        public int x = 0;
        private void ThongtinNganh_Load(object sender, EventArgs e)
        {
            
        }

        void TakeData(string a)
        {
            command1 = connection.CreateCommand();
            command1.CommandText = "select * from XET";
            adapter.SelectCommand = command1;
            table1.Clear();
            adapter.Fill(table1);

            command2 = connection.CreateCommand();
            command2.CommandText = "select * from NGANH";
            adapter.SelectCommand = command2;
            table2.Clear();
            adapter.Fill(table2);

            tabble.Columns.Add("STT");
            tabble.Columns.Add("Tên Ngành");
            tabble.Columns.Add("Mã Ngành");
            tabble.Columns.Add("Tổ Hợp");
            //groupBox2.Show();
            tabble.Clear();

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
                    tabble.Rows.Add(b);
                }
                i++;

            }
            dataGridView1.DataSource = tabble;
            SetColorRowDT();
        }

        private void UserControl3_VisibleChanged(object sender, EventArgs e)
        {
            if((y != 0)&&(x != 0))
            {
                connection = new SqlCeConnection(str);
                connection.Open();
                TakeData(Code);
                SetCol();
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

        void SetCol()
        {
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 400;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Width = 140;
        }
    }
}

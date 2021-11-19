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
namespace Respond
{
    public partial class Form1 : Form
    {
        int i=0;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            i++;
            if (richTextBox1.Text=="")
            {
                richTextBox1.Text = "Gửi cho chúng tôi thông tin về lỗi mà bạn gặp phải trong quá trình sử dụng sản phẩm, việc bạn mô tả càng chi tiết sẽ giúp chúng tôi nhanh chống và dễ dàng sửa được lỗi đó hơn, xin chân thành cám ơn.";
                i = 0;
                this.richTextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            }    
            if (i==1)
            {
               string s1 = richTextBox1.Text;
                string s="";
                s += s1[0];
                richTextBox1.Text =s;
                richTextBox1.SelectionStart = richTextBox1.Right;
                this.richTextBox1.ForeColor = Color.Black;
            }    
        }

        private void richTextBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        
        }
    }
}

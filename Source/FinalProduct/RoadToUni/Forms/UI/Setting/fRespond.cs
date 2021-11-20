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
using System.Net.Mail;
using System.IO;
using System.Net;
namespace RoadToUni.Forms.UI.Setting
{
    public partial class fRespond : Form
    {
        int i = 0;
        string fileName;
        Attachment attach = null;
        public fRespond()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {


                this.ClientSize = new System.Drawing.Size(405, 610);
                //this.button1.Location = new System.Drawing.Point(180, 557);
                //this.button2.Location = new System.Drawing.Point(250, 557);
            }
            else
            {
                pictureBox1.Image = null;
                //this.button1.Location = new System.Drawing.Point(160, 260);
                //this.button2.Location = new System.Drawing.Point(230, 260);
                this.ClientSize = new System.Drawing.Size(405, 300);


            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            i++;
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Gửi cho chúng tôi thông tin về lỗi mà bạn gặp phải trong quá trình sử dụng sản phẩm, việc bạn mô tả càng chi tiết sẽ giúp chúng tôi nhanh chống và dễ dàng sửa được lỗi đó hơn, xin chân thành cám ơn.";
                i = 0;
                this.richTextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
                button2.Enabled = false;
            }
            if (i == 1)
            {
                string s1 = richTextBox1.Text;
                string s = "";
                s += s1[0];
                richTextBox1.Text = s;
                richTextBox1.SelectionStart = richTextBox1.Right;
                this.richTextBox1.ForeColor = Color.Black;
                button2.Enabled = true;
            }
        }
        void sendMail(string from, string to, string subject, string message, Attachment file = null)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);
            if (attach != null)
            {
                mess.Attachments.Add(attach);
            }
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("roadtouni2021@gmail.com", "meowmeow1234");
            client.Send(mess);
        }
        private void richTextBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "*.JPEG|*.JPG|*.PNG|*.GIF|All files (*.*)|*.*";
            // fileDialog.Filter = "*.txt|*.txt|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = fileDialog.FileName;
                pictureBox1.Image = Image.FromFile(fileName);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            attach = null;
            try
            {
                FileInfo file = new FileInfo(fileName);
                attach = new Attachment(fileName);
            }
            catch { }
            sendMail("roadtouni2021@gmail.com", "roadtouni2021@gmail.com", "Báo Cáo Lỗi", richTextBox1.Text, attach);
            MessageBox.Show("Gửi thành công,cám ơn phản hồi của bạn");
        }
    }
}

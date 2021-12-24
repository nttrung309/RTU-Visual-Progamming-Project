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
using System.Runtime;
using System.Runtime.InteropServices;

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
        //Creating the extern function...  
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        //Creating a function that uses the API function...  
        public static bool IsConnectedToInternet()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //btnSend.Enabled = false;
            pictureBox1.Image = null;
            //this.button1.Location = new System.Drawing.Point(160, 260);
            //this.button2.Location = new System.Drawing.Point(230, 260);
            //this.ClientSize = new System.Drawing.Size(405, 300);
            this.btnChoosePic.Visible = false;
            this.pictureBox1.Visible = false;
            label.Location = new Point((this.Width - label.Width) / 2, label.Location.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckboxPic.Checked == true)
            {


                this.ClientSize = new System.Drawing.Size(405, 610);
                //this.button1.Location = new System.Drawing.Point(180, 557);
                //this.button2.Location = new System.Drawing.Point(250, 557);
                this.btnChoosePic.Visible = true;
                this.pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Image = null;
                //this.button1.Location = new System.Drawing.Point(160, 260);
                //this.button2.Location = new System.Drawing.Point(230, 260);
                //this.ClientSize = new System.Drawing.Size(405, 300);
                this.btnChoosePic.Visible = false;
                this.pictureBox1.Visible = false;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            i++;
            if (txbContent.Text == "")
            {
                txbContent.Texts = "Gửi cho chúng tôi thông tin về lỗi mà bạn gặp phải trong quá trình sử dụng sản phẩm, việc bạn mô tả càng chi tiết sẽ giúp chúng tôi nhanh chóng và dễ dàng sửa được lỗi đó hơn, xin chân thành cám ơn.";
                i = 0;
                this.txbContent.ForeColor = System.Drawing.SystemColors.ScrollBar;
                btnSend.Enabled = false;
            }
            if (i == 1)
            {
                string s1 = txbContent.Text;
                string s = "";
                s += s1[0];
                txbContent.Texts = s;
                //txbContent.SelectionStart = txbContent.Right;
                this.txbContent.ForeColor = Color.Black;
                btnSend.Enabled = true;
            }
        }
        void sendMail(string from, string to, string subject, string message, Attachment file = null)
        {
            string senderName = (txbSender.Texts != "") ? txbSender.Texts : "Ẩn danh";
            message = "Người gửi: " + senderName + "\n\nNội dung: " + message;
            MailMessage mess = new MailMessage(from, to, subject, message);
            if (attach != null)
            {
                mess.Attachments.Add(attach);
            }
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("roadtouni2021@gmail.com", "meowmeow1234");
            client.Send(mess);
            MessageBox.Show("Gửi thành công, cảm ơn phản hồi của bạn","Thành công",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ckboxPic.Checked = false;
            pictureBox1.Image = null;
            //this.button1.Location = new System.Drawing.Point(160, 260);
            //this.button2.Location = new System.Drawing.Point(230, 260);
            //this.ClientSize = new System.Drawing.Size(405, 300);
            this.btnChoosePic.Visible = false;
            this.pictureBox1.Visible = false;
            this.txbContent.Texts = "";
            this.txbSender.Texts = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txbContent.Texts = "";
            this.txbSender.Texts = "";
            this.btnChoosePic.Visible = false;
            this.pictureBox1.Visible = false;
            ckboxPic.Checked = false;
            pictureBox1.Image = null;
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
            if (IsConnectedToInternet())
            {
                if(txbContent.Texts == "" && pictureBox1.Image == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        FileInfo file = new FileInfo(fileName);
                        attach = new Attachment(fileName);
                    }
                    catch { }
                    Task.Run(() => sendMail("roadtouni2021@gmail.com", "roadtouni2021@gmail.com", "Báo Cáo Lỗi", txbContent.Texts, attach));
                }
            }
            else
            {
                MessageBox.Show("Vui lòng thử lại khi kết nối với Internet!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}

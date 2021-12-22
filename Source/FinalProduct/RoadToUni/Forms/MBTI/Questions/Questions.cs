using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Đồ_án_1
{
    public partial class Cau01_02 : Form
    {
         static public int a { get; set; }
         static public int b { get; set; }
         static public int c { get; set; }
         static public int d { get; set; }
         static public int e { get; set; }
         static public int f { get; set; }
         static public int g { get; set; }
         static public int h { get; set; }

         public int QuestionNumber = 1;


        public Cau01_02()
        {
            InitializeComponent();
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            e = 0;
            f = 0;
            g = 0;
            h = 0;
            QuestionNumber = 1;
        }

        void changeText()
        {
            if (QuestionNumber == 3)
            {
                Cau1.Text = "Câu 3:";
                Cau2.Text = "Câu 4:";
                label5.Text = "Khi phải đưa ra quyết định, bạn … ";
                label6.Text = "Khi làm việc bạn thường:";
                radioButton1.Text = "Quyết định mọi việc rất khách quan.";
                radioButton2.Text = "Quyết định mọi việc theo giá trị riêng của chúng và ";
                radioButton3.Text = "Thực hiện đúng kế hoạch đặt ra, không muốn thay đổi.";
                radioButton4.Text = "Linh hoạt khi thực hiện các kế hoạch ";
            }
            if (QuestionNumber == 5)
            {
                Cau1.Text = "Câu 5:";
                Cau2.Text = "Câu 6:";
                label5.Text = "Trong những buổi họp mặt hay tranh luận cùng bạn bè, bạn …";
                label6.Text = "Bạn là người:";
                radioButton1.Text = "Thích là tâm điểm của sự chú ý.";
                radioButton2.Text = "Cảm thấy thoải mái khi ở một mình.";
                radioButton3.Text = "Thích những giải pháp thực tế.";
                radioButton4.Text = "Thích những ý tưởng sáng tạo.";
            }
            if (QuestionNumber == 7)
            {
                Cau1.Text = "Câu 7:";
                Cau2.Text = "Câu 8:";
                label5.Text = "Trong các cuộc thảo luận bạn thường:";
                label6.Text = "Thói quen làm việc của bạn:";
                radioButton3.Text = "Rất chú trọng đến thời gian và luôn đúng giờ.";
                radioButton4.Text = "Ít quan tâm đến thời gian và thường trễ hẹn.";
                radioButton1.Text = "Thường tranh luận cho vui.";
                radioButton2.Text = "Cố gắng tránh tất cả tranh luận và đối đầu.";
            }
            if (QuestionNumber == 9)
            {
                Cau1.Text = "Câu 9:";
                Cau2.Text = "Câu 10:";
                label5.Text = "Quan điểm sống của bạn là …";
                label6.Text = "Khi bạn đối mặt với vấn đề:";
                radioButton1.Text = "Hành động trước khi suy nghĩ.";
                radioButton2.Text = "Suy nghĩ thật “chín” trước khi hành động.";
                radioButton3.Text = "Chỉ tin vào kinh nghiệm thực tế.";
                radioButton4.Text = "Chỉ tin vào bản năng mà thôi.";
            }
            if (QuestionNumber == 11)
            {
                Cau1.Text = "Câu 11:";
                Cau2.Text = "Câu 12:";
                label5.Text = "Châm ngôn sống của bạn:";
                label6.Text = "Bạn thường:";
                radioButton1.Text = "Xem trọng tính trung thực và công bằng.";
                radioButton2.Text = "Xem trọng sự hòa thuận và tình thương. ";
                radioButton3.Text = "Làm việc trước, chơi sau.";
                radioButton4.Text = "Chơi trước và làm việc sau.";
            }
            if (QuestionNumber == 13)
            {
                Cau1.Text = "Câu 13:";
                Cau2.Text = "Câu 14:";
                label5.Text = "Trong công việc, bạn …";
                label6.Text = "Bạn thường để ý tới:";
                radioButton1.Text = "Thích “đóng vai chính”.";
                radioButton2.Text = "Thích “ẩn mình” sau “hậu trường”.";
                radioButton3.Text = "Chú ý mọi chi tiết và nhớ tất cả sự việc.";
                radioButton4.Text = "Chỉ chú ý những điều mới lạ.";
            }
            if (QuestionNumber == 15)
            {
                Cau1.Text = "Câu 15:";
                Cau2.Text = "Câu 16:";
                label5.Text = "Khi được khen ngợi trong công ty:";
                label6.Text = "Khi đưa ra quyết định bạn:";
                radioButton1.Text = "Nguồn động viên chính là thành tích đạt được.";
                radioButton2.Text = "Cảm thấy “ấm lòng” vì sự công nhận của sếp.";
                radioButton3.Text = "Quyết định mọi việc khá dễ dàng.";
                radioButton4.Text = "Có thể ra quyết định khá khó khăn.";
            }
            if (QuestionNumber == 17)
            {
                Cau1.Text = "Câu 17:";
                Cau2.Text = "Câu 18:";
                label5.Text = "Nhìn chung bạn có khuynh hướng …";
                label6.Text = "Bạn nhận thấy bản thân như thế nào:";
                radioButton1.Text = "Thoải mái và nhiệt tình.";
                radioButton2.Text = "Độc lập và kín đáo.";
                radioButton3.Text = "Có óc thực tế - thấy điều cụ thể trước mắt.";
                radioButton4.Text = "Có óc sáng tạo – thấy điều có thể làm được.";
            }
            if (QuestionNumber == 19)
            {
                Cau1.Text = "Câu 19:";
                Cau2.Text = "Câu 20:";
                label5.Text = "Bạn bị thuyết phục bởi:";
                label6.Text = "Cách làm việc của bạn:";
                radioButton1.Text = "Bị thuyết phục bởi những lập luận có lý.";
                radioButton2.Text = "Bị thuyết phục bởi cảm giác của bản thân.";
                radioButton3.Text = "Chỉ cảm thấy thoải mái khi mọi việc đã có kế hoạch rõ ràng.";
                radioButton4.Text = "Thích tự do và ứng biến tùy lúc.";
                //Meow.SwitchForm(new KetQua());
            }
        }
        private void Next1_Click(object sender, EventArgs z)
        {
            if (((radioButton1.Checked == false) && (radioButton2.Checked == false)) || ((radioButton3.Checked == false) && (radioButton4.Checked == false)))
            {
                MessageBox.Show("Có câu hỏi chưa được chọn","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                QuestionNumber += 2;
                if ((QuestionNumber == 1) || (QuestionNumber == 5) || (QuestionNumber == 9) || (QuestionNumber == 13) || (QuestionNumber == 17))
                {
                    if (radioButton1.Checked == true)
                    {
                        a++;
                    }
                    if (radioButton2.Checked == true)
                    {
                        b++;
                    }
                    if (radioButton3.Checked == true)
                    {
                        c++;
                    }
                    if (radioButton4.Checked == true)
                    {
                        d++;
                    }
                }
                else
                {
                    if (radioButton1.Checked == true)
                    {
                        e++;
                    }
                    if (radioButton2.Checked == true)
                    {
                        f++;
                    }
                    if (radioButton3.Checked == true)
                    {
                        g++;
                    }
                    if (radioButton4.Checked == true)
                    {
                        h++;
                    }
                }
                //Meow.SwitchForm();
                
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                changeText();
                if(QuestionNumber == 21)
                {
                    Meow.SwitchForm(new KetQua());
                }
            }
            
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}

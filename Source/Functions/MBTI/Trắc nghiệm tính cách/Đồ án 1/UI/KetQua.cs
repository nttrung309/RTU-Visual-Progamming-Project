using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_1
{
    public partial class KetQua : Form
    {
        
        static string index1 = "";
        static string index2 = "";
        static string index3 = "";
        static string index4 = "";
        static string a = "";
        //static string code;
        public static string[] major = { "Báo chí - Marketing - Quảng cáo - PR", "Công an - Quân đội", "Công nghệ chế biến thực phẩm", "Công nghệ thông tin - Tin học", "Công nghệ vật liệu", "Điện lạnh- Điện tử - Điện - Tự động hóa", "Du lịch-Khách sạn", "Hàng không - Vũ trụ- Hạt nhân", "Kế toán - Kiểm toán", "Kinh tế - Quản trị kinh doanh - Thương Mại", "Luật - Tòa án", "Mỹ thuật - Âm nhạc-Nghệ thuật", "Ngoại giao - Ngoại ngữ", "Sư phạm - Giáo dục", "Tài chính - Ngân hàng- Bảo hiểm", "Thể dục - Thể thao", "Toán học và thống kê", "Tài nguyên- Môi trường", "Thủy sản-Lâm Nghiệp-Nông nghiệp", "Văn hóa - Chính trị - Khoa học Xã hội", "Y - Dược" };
        Point p = new Point(114,222);
        public static UserControl1 user = new UserControl1();
        public static UserControl2 user2 = new UserControl2();
        public static UserControl3 user3 = new UserControl3();
        public static UserControl4 user4 = new UserControl4();
        public KetQua()
        {
            //Controls.Add(user);
            //user.Location = p;
            //user.Size.Width = panel2.Width;
            //user.Size.Height = panel2.Height;
            //user.Size = panel2.Size;
            //user.BringToFront();
            //user.Show();
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(user);
            flowLayoutPanel1.Controls.Add(user2);
            flowLayoutPanel1.Controls.Add(user3);
            flowLayoutPanel1.Controls.Add(user4);
            //user.Dock = DockStyle.Fill;
            MBTI();
            a = string.Concat(index1, index2, index3, index4);
            user2.linkLabel1.Show();
            user2.linkLabel2.Show();
            user2.linkLabel3.Show();
            user2.linkLabel4.Show();
            if (a == "ENFJ")//1
            {
                user3.label1.Text = "- Martin Luther King";
                user3.label2.Text = "Jr. - Abraham Lincoln";
                user3.label3.Text = "- Nelson Mandela";
                label3.Text = "ENFJ (Extrovert, Intuitive, Feeler, Judger)";
                //user.label4.Width = 1406;
                user.label4.Text = "Có khoảng 2% dân số mang loại tính cách này. Bạn là người dễ cảm thông và độc đáo. Bạn thích làm việc trong môi trường ngăn nắp. Bạn rất có trách nhiệm. Khi làm bất cứ việc gì, bạn thường dồn hết tâm trí của mình vào đó.";
                //user.Height = user.label4.Height;
                //user2.label5.Text = ;
                user3.label8.Text = "Những người nổi tiếng mang tính cách ENFJ: ";
                user2.linkLabel1.Text = major[0]+ " || Chuyên viên quảng cáo, Biên tập tạp chí, Nhà văn / Nhà báo, Nhân viên marketing";
                user2.linkLabel2.Text = major[11]+ " ||  Nhà sản xuất các chương trình TV";
                user2.linkLabel3.Hide();
                user2.linkLabel4.Hide();
            }
            if (a == "ENFP")//2
            {
                user3.label1.Text = "- Walt Disney";
                user3.label2.Text = "- Oscar Wilde";
                user3.label3.Text = "- Hunter S. Thompson";
                label3.Text = "ENFP (Extrovert, Intuitive, Feeler, Perceiver)";
                user.label4.Text = "Có khoảng 7% dân số mang loại tính cách này. Thật tuyệt vời! Bạn rất thông minh và luôn muốn học hỏi nhiều hơn. Bạn nói khá nhiều và là người khá thoải mái. Bạn rất nhiệt tình, có nhiều sáng kiến. Bạn thường dễ dàng vượt qua mọi khó khăn.";
                //user2.label5.Text = "*Nghề nghiệp phù hợp với bạn:    , .";
                user3.label8.Text = "Những người nổi tiếng mang tính cách ENFP: ";
                user2.linkLabel1.Text = major[0]+" || Nhân viên quảng cáo, Nhà báo";
                user2.linkLabel2.Text = major[3]+" || Chuyên viên Phát triển phần mềm";
                user2.linkLabel3.Text = major[11]+ " || Giám đốc sáng tạo, Nhà thiết kế";
                user2.linkLabel4.Hide();
            }
            if (a == "ENTJ")//3
            {
                user3.label1.Text = "- Napoleon Bonaparte";
                user3.label2.Text = "- Julius Caesar";
                user3.label3.Text = "- Margaret Thatcher";
                label3.Text = "ENTJ (Extrovert, Intuitive, Thinker, Judger)";
                user.label4.Text = "Có khoảng 3% dân số mang loại tính cách này. Bạn khá thân thiện với mọi người. Tuy nhiên bạn là người rất kiên quyết và thẳng tính. Vì vậy bạn có thể làm tổn thương người khác. Bạn rất quyết đoán và ngăn nắp.";
                //user2.label5.Text = "*Bạn có thể trở thành: , , .";
                user3.label8.Text = "Những người nổi tiếng mang tính cách ENTJ:  ";
                user2.linkLabel1.Text = major[0]+ " || Nhân viên marketing";
                user2.linkLabel2.Text = major[9] + " || Chuyên viên nhà đất, Nhà phân tích tài chính, Tư vấn viên, Giám đốc điều hành";
                user2.linkLabel3.Hide();
                user2.linkLabel4.Hide();
            }
            if (a == "ENTP")//4
            {
                user3.label1.Text = "- Theodore Roosevelt";
                user3.label2.Text = "- Benjamin Franklin";
                user3.label3.Text = "- Thomas Edison";
                label3.Text = "ENTP (Extrovert, Intuitive, Thinker, Perceiver)";
                user.label4.Text = "Có khoảng 3% dân số mang loại tính cách này. Bạn rất có duyên. Mọi người đều thích bạn vì bạn là người thân thiện và thoải mái. Bạn rất sáng tạo, nhưng cũng dễ thay đổi. Khả năng phân tích của bạn khá tốt.";
                //user2.label5.Text = "*Bạn nên làm những công việc:   .";
                user3.label8.Text = "Những người nổi tiếng mang tính cách ENTP: ";
                user2.linkLabel1.Text = major[0] + " || Người viết quảng cáo";
                user2.linkLabel2.Text = major[9] + " || Hoạch định chiến lược";
                user2.linkLabel3.Text = major[14]+" ||  Đầu tư ngân hàng";
                user2.linkLabel4.Text = major[11]+" || Phát thanh viên radio/TV";
            }
            if (a == "ESFJ")//5
            {
                user3.label1.Text = "- Harry S. Truman";
                user3.label2.Text = "- Gerald Ford";
                user3.label3.Text = "- Desmond Tutu";
                label3.Text = "ESFJ (Extrovert, Sensor, Feeler, Judger)";
                user.label4.Text = "Có khoảng 12% dân số mang tính cách này. Bạn rất năng động và tràn đầy nhiệt huyết. Tuy nhiên bạn khá nhạy cảm và dễ bị tổn thương. Bạn là người ngăn nắp và có trách nhiệm. Bạn không thích sự thay đổi.";
                user3.label8.Text = "Những người nổi tiếng mang tính cách ESFJ:  ";
                //user2.label5.Text = "*Bạn có thể là một , , , , .";
                user2.linkLabel1.Text = major[9] + " || Chuyên gia kinh doanh Bất động sản, Nhân viên kinh doanh";
                user2.linkLabel2.Text = major[20] + " || Bác sĩ thú y, Y tá";
                user2.linkLabel3.Text = major[13] + " || Giáo viên";
                user2.linkLabel4.Text = major[6]+" || Nhân viên du lịch";
            }
            if (a == "ESFP")//6
            {
                user3.label1.Text = "- Ronald Reagan";
                user3.label2.Text = "- Hugh Hefner";
                user3.label3.Text = "- Howard Schultz";
                label3.Text = "ESFP (Extrovert, Sensor, Feeler, Perceiver)";
                user.label4.Text = "Có khoảng 7.5% dân số mang tính cách này. Bạn khá thoải mái và khôi hài. Vì vậy đừng ngạc nhiên khi thỉnh thoảng bạn cảm thấy mình hơi bốc đồng nhé! Tuy nhiên bạn rất ham học hỏi. Bạn rất năng động và yêu các hoạt động xã hội.";
                user3.label8.Text = "Những người nổi tiếng mang tính cách ESFP:  ";
                //user2.label5.Text = "*Bạn có thể trở thành một , .";
                user2.linkLabel1.Text = major[20] + " || Bác sĩ chuyên khoa, Bác sĩ thú y, Nha sĩ";
                user2.linkLabel2.Text = major[13] + " || Giáo viên mầm non";
                user2.linkLabel3.Hide();
                user2.linkLabel4.Hide();
            }
            if (a == "ESTJ")//7
            {
                user3.label1.Text = "- Bernard Montgomery";
                user3.label2.Text = "- Henry Ford";
                user3.label3.Text = "- George W. Bush";
                user3.label8.Text = "Những người nổi tiếng mang tính cách ESTJ:  ";
                label3.Text = "ESTJ (Extrovert, Sensor, Thinker, Judger)";
                user.label4.Text = "Có khoảng 11,5% dân số mang tính cách này. Bạn có khuynh hướng nói thẳng những điều bạn nghĩ. Bạn rất thực tế, khó thay đổi ý kiến và nghiêm túc. Bạn yêu thích tính truyền thống và rất giỏi quyết định mọi chuyện.";
                //user2.label5.Text = "*Bạn có thể trở thành  , .";
                user2.linkLabel1.Text = major[9] + " || Nhân viên kinh doanh, Nhân viên bất động sản";
                user2.linkLabel2.Text = major[20] + " || Dược sĩ";
                user2.linkLabel3.Text = major[1] + " || Sĩ quan";
                user2.linkLabel4.Hide();
            }
            if (a == "ESTP")//8
            {
                user3.label1.Text = "- Ernest Hemingway";
                user3.label2.Text = "- Eddie Murphy";
                user3.label3.Text = "- Jack Nicholson";
                user3.label8.Text = "Những người nổi tiếng mang tính cách ESTP: ";
                label3.Text = "ESTP (Extrovert, Sensor, Thinker, Perceiver)";
                user.label4.Text = "Có khoảng 4% dân số mang tính cách này. Bạn là người năng động, vui vẻ và quyến rũ nhưng hơi bốc đồng. Bạn thích thử thách và luôn luôn muốn học hỏi thêm nhiều điều mới lạ. Bạn cũng là người hiếu kỳ, điềm đạm và suy nghĩ lôgic.";
                //user2.label5.Text = "*Bạn có thể trở thành , , , Kỹ sư, .";
                user2.linkLabel1.Text = major[20] + " || Nhân viên y tế";
                user2.linkLabel2.Text = major[14] + " || Nhân viên bảo hiểm";
                user2.linkLabel3.Text = major[6] + " || Nhân viên du lịch";
                user2.linkLabel4.Text = major[0]+" || Môi giới chứng khoán";
            }
            if (a == "INFJ")//9
            {
                user3.label1.Text = "- Adam Sandler";
                user3.label2.Text = "- Adolf Hitler";
                user3.label3.Text = "- Calvin Coolidge";
                user3.label8.Text = "Những người nổi tiếng mang tính cách INFJ:  ";
                label3.Text = "INFJ (Introvert, Intuitive, Feeler, Judger)";
                user.label4.Text = "Có rất ít người mang tính cách này, chỉ chiếm khoảng 1% dân số. Bạn khá sáng tạo và có khả năng làm việc độc lập. Bạn luôn luôn suy nghĩ kĩ trước khi làm bất cứ việc gì. Bạn luôn dành hết đam mê cho những gì mình làm.";
                //user2.label5.Text = "*Nghề nghiệp phù hợp với bạn là: , , , , .";
                user2.linkLabel1.Text = major[11] + " || Giám đốc sáng tạo";
                user2.linkLabel2.Text = major[13] + " || Giáo viên";
                user2.linkLabel3.Text = major[15] + " || Chuyên viên huấn luyện";
                user2.linkLabel4.Text = major[19]+" || Biên tập viên, Nhà văn";
            }
            if (a == "INFP")//10
            {
                user3.label1.Text = "- William Shakespeare";
                user3.label2.Text = "- J.K. Rowling";
                user3.label3.Text = "- Antoine de Saint-Exupery";
                user3.label8.Text = "Những người nổi tiếng mang tính cách INFP:  ";
                label3.Text = "INFP (Introvert, Intuitive, Feeler, Perceiver)";
                user.label4.Text = "Có khoảng 4,5% dân số mang tính cách này. Bạn khá trầm lặng, kín đáo và tốt bụng. Thỉnh thoảng bạn khá nhạy cảm nên cũng dễ bị tổn thương. Bạn là người sáng tạo, độc đáo và giàu trí tưởng tượng.";
                //user2.label5.Text = "*Những nghề thích hợp với bạn: , u, , Thủ thư, , .";
                user2.linkLabel1.Text = major[19] + " || Biên tập viên, Nhà tâm lý học, Nhà nghiên cứu";
                user2.linkLabel2.Text = major[12] + " || Thông dịch viên ";
                user2.linkLabel3.Text = major[11] + " || Thiết kế thời trang";
                user2.linkLabel4.Text = major[9]+" || Chuyên gia nhân sự";
            }
            if (a == "INTJ")//11
            {
                user3.label1.Text = "- Vladimir Putin";
                user3.label2.Text = "- Augustus Caesar";
                user3.label3.Text = "- Bill Gates";
                user3.label8.Text = "Những người nổi tiếng mang tính cách INTJ:  ";
                label3.Text = "INTJ (Introvert, Intuitive, Thinker, Judger)";
                user.label4.Text = "Có khoảng 2% dân số mang tính cách này. Bạn thích sự độc lập và ngăn nắp. Bạn là người giàu trí tưởng tượng. Bạn có óc phân tích và lôgic. Bạn luôn khát khao nâng cao năng lực và kiến thứccủa mình. Bạn khá thận trọng và kín đáo.";
                //user2.label5.Text = "*Những nghề phù hợp với bạn:  , Kiến trúc sư, .";
                user2.linkLabel1.Text = major[19] + " || Nhà văn tự do,";
                user2.linkLabel2.Text = major[0]+" || Hoạch định truyền thông";
                user2.linkLabel3.Text = major[3]+" || Quản trị mạng, Phát triển phần mềm";
                user2.linkLabel4.Hide();
            }
            if (a == "INTP")//12
            {
                user3.label1.Text = "- Isaac Newton";
                user3.label2.Text = "- Albert Einstein";
                user3.label3.Text = "- James Madison";
                user3.label8.Text = "Những người nổi tiếng mang tính cách INTP:   ";
                label3.Text = "INTP (Introvert, Intuitive, Thinker, Perceiver)";
                user.label4.Text = "Có khoảng 3% dân số mang tính cách INTP. Bạn khá trầm lặng. Bạn có khả năng làm việc độc lập cao. Người khác có thể kể với bạn những bí mật của họ vì bạn là người rất kín đáo. Bạn là người sáng tạo và khéo léo, nhưng bạn cũng hay thay đổi.";
                //user2.label5.Text = "*Bạn có thể phát triển nghề nghiệp của mình theo hướng: , , , , .";
                user2.linkLabel1.Text = major[9]+" || Chuyên viên phân tích tài chính, Nhà kinh tế học, Xây dựng chiến lược";
                user2.linkLabel2.Text = major[3] + " || Thiết kế Web";
                user2.linkLabel3.Text = major[11]+" || Nhạc sĩ";
                user2.linkLabel4.Hide();
            }
            if (a == "ISFJ")//13
            {
                user3.label1.Text = "- Jimmy Carter";
                user3.label2.Text = "- William Howard Taft";
                user3.label3.Text = "- Ed Bradley";
                user3.label8.Text = "Những người nổi tiếng mang tính cách ISFJ:  ";
                label3.Text = "ISFJ (Introvert, Sensor, Feeler, Judger)";
                user.label4.Text = "Có khoảng 12.5% dân số trên thế giới mang loại tính cách này. Bạn là người cẩn thận, hiền lành và sâu sắc. Bạn làm việc chăm chỉ, có óc tổ chức và kiên quyết. Bạn rất quan tâm đến người khác. Bạn thích cuộc sống ổn định và giúp đỡ người khác.";
                //user2.label5.Text = "*Những nghề thích hợp với bạn gồm Thủ thư, Người trang trí nội thất,,  .";
                user2.linkLabel1.Text = major[13] + " || Giáo viên";
                user2.linkLabel2.Text = major[8]+" || Nhân viên kế toán";
                user2.linkLabel3.Text = major[0]+" || Chăm sóc khách hàng ";
                user2.linkLabel4.Hide();
            }
            if (a == "ISFP")//14
            {
                user3.label1.Text = "- Donald Trump";
                user3.label2.Text = "- Elizabeth Taylor";
                user3.label3.Text = "- Michael Jackson";
                user3.label8.Text = "Những người nổi tiếng mang tính cách ISFP: ";
                label3.Text = "ISFP (Introvert, Sensor, Feeler, Perceiver)";
                user.label4.Text = "Có khoảng 8% dân số mang tính cách này. Bạn rất tốt bụng và dễ cảm thông. Bạn là người chu đáo và trung thực. Bạn khá nhạy cảm nên rất dễ bị tổn thương. Tuy nhiên bạn rất dễ thích ứng với sự thay đổi.";
                //user2.label5.Text = "*Bạn có thể trở thành , , Đầu bếp, Nha sĩ.";
                user2.linkLabel1.Text = major[0] + " || Chăm sóc khách hàng, Nhân viên thiết kế";
                user2.linkLabel2.Text = major[20] + " || Nha sĩ";
                user2.linkLabel3.Hide();
                user2.linkLabel4.Hide();
            }
            if (a == "ISTJ")//15
            {
                user3.label1.Text = "- George Washington";
                user3.label2.Text = "- Jeff Bezos";
                user3.label3.Text = "- Angela Merkel";
                user3.label8.Text = "Những người nổi tiếng mang tính cách ISTJ:  ";
                label3.Text = "ISTJ (Introvert, Sensor, Thinker, Judger)";
                user.label4.Text = "Có đến 13% dân số trên thế giới thuộc nhóm tính cách này. Bạn là người trầm lặng. Bạn rất cẩn thận, trung thực và tỉ mỉ. Bạn thích sự ổn định, nhưng bạn cũng có thể thích nghi với sự thay đổi. Bạn làm việc chăm chỉ và rất có trách nhiệm.";
                //user2.label5.Text = "* Bạn có thể phát triển nghề nghiệp của mình theo hướng: , , Kế toán, Thanh tra xây dựng, .";
                user2.linkLabel1.Text = major[9] + " || Môi giới bất động sản, Quản lý văn phòng";
                user2.linkLabel2.Text = major[8] + " || Kế toán";
                user2.linkLabel3.Text = major[3] + " || Quản lý dữ liệu";
                user2.linkLabel4.Hide();
            }
            if (a == "ISTP")//16
            {
                user3.label1.Text = "- Tom Cruise";
                user3.label2.Text = "- Frank Zappa";
                user3.label3.Text = "- Zachary Taylor";
                user3.label8.Text = "Những người nổi tiếng mang tính cách ISTP: ";
                label3.Text = "ISTP (Introvert, Sensor, Thinker, Perceiver)";
                user.label4.Text = "Có khoảng 5% dân số mang tính cách này. Bạn là một người rất thực tế. Bạn thích sự độc lập và yên tĩnh. Đôi lúc bạn cũng bốc đồng. Bạn là người theo chủ nghĩa khách quan và không dễ xúc động.";
                //user2.label5.Text = "*Những nghề thích hợp với bạn: ,, Dược sĩ.";
                user2.linkLabel1.Text = major[20] + " || Dược sĩ";
                user2.linkLabel2.Text = major[3]+" || Lập trình viên";
                user2.linkLabel3.Text = major[1] + " || Cảnh sát, Lính cứu hỏa";
                user2.linkLabel4.Hide();
            }
            user4.label6.Text = "Bạn biết đấy không có gì là hoàn hảo cả . Nhưng chúng tôi hy vọng bài trắc nghiệm này sẽ giúp bạn khám phá khả năng thật sự của mình.Từ đó bạn sẽ xác định được đâu là công việc phù hợp nhất với bạn để phát triển đúng hướng cho sự nghiệp của mình.";
            user3.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Images\\" + a + "1" + ".jpg");
            user3.pictureBox2.Image = new Bitmap(Application.StartupPath + "\\Images\\" + a + "2" + ".jpg");
            user3.pictureBox3.Image = new Bitmap(Application.StartupPath + "\\Images\\" + a + "3" + ".jpg");
            
        }

        private void MBTI(/*string a*/)
        {
            if (Cau01_02.a > Cau01_02.b)
            {
                index1 = "E";
                //a += index1;
            }
            else
            {
                index1 = "I";
                //a += index1;
            }
            if (Cau01_02.c > Cau01_02.d)
            {
                index2 = "S";
                //a += index2;
            }
            else
            {
                index2 = "N";
                //a += index2;
            }
            if (Cau01_02.e > Cau01_02.f)
            {
                index3 = "T";
                //a += index3;
            }
            else
            {
                index3 = "F";
                //a += index3;
            }
            if (Cau01_02.g > Cau01_02.h)
            {
                index4 = "J";
                //a += index4;
            }
            else
            {
                index4 = "P";
                //a += index4;
            }
            //a = string.Concat(index1,index2,index3,index4);
            //MessageBox.Show(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Meow.SwitchForm(new Cau01_02());
        }

        private void KetQua_Load(object sender, EventArgs e)
        {
            //panel2.AutoScroll = false;
            //panel2.HorizontalScroll.Enabled = false;
            //panel2.HorizontalScroll.Visible = false;
            //panel2.HorizontalScroll.Maximum = 0;
            //panel2.AutoScroll = true;
        }

    }
}

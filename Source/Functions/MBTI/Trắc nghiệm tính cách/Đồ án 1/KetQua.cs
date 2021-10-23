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
        public KetQua()
        {            
            InitializeComponent();
            MBTI(a);
            a = string.Concat(index1, index2, index3, index4);
            if(a == "ENFJ")//1
            {
                label3.Text = "ENFJ (Extrovert, Intuitive, Feeler, Judger)";
                label4.Text = "Có khoảng 2% dân số mang loại tính cách này. Bạn là người dễ cảm thông và độc đáo. Bạn thích làm việc trong môi trường ngăn nắp. Bạn rất có trách nhiệm. Khi làm bất cứ việc gì, bạn thường dồn hết tâm trí của mình vào đó."; 
                label5.Text = "*Bạn có thể trở thành một Chuyên viên quảng cáo, Biên tập tạp chí, Nhà sản xuất các chương trình TV, Nhân viên marketing, Nhà văn / Nhà báo.";
                label8.Text = "Những người nổi tiếng mang tính cách ENFJ: - Martin Luther King, Jr. - Abraham Lincoln - Nelson Mandela";
            }
            if (a == "ENFP")//2
            {
                label3.Text = "ENFP (Extrovert, Intuitive, Feeler, Perceiver)";
                label4.Text = "Có khoảng 7% dân số mang loại tính cách này. Thật tuyệt vời! Bạn rất thông minh và luôn muốn học hỏi nhiều hơn. Bạn nói khá nhiều và là người khá thoải mái. Bạn rất nhiệt tình, có nhiều sáng kiến. Bạn thường dễ dàng vượt qua mọi khó khăn.";
                label5.Text = "*Nghề nghiệp phù hợp với bạn: Nhân viên quảng cáo, chuyên viên Phát triển phần mềm, Nhà báo, Nhà thiết kế, Giám đốc sáng tạo.";
                label8.Text = "Những người nổi tiếng mang tính cách ENFJ: - Walt Disney, - Oscar Wilde, - Hunter S. Thompson";
            }
            if (a == "ENTJ")//3
            {
                label3.Text = "ENTJ (Extrovert, Intuitive, Thinker, Judger)";
                label4.Text = "Có khoảng 3% dân số mang loại tính cách này. Bạn khá thân thiện với mọi người. Tuy nhiên bạn là người rất kiên quyết và thẳng tính. Vì vậy bạn có thể làm tổn thương người khác. Bạn rất quyết đoán và ngăn nắp.";
                label5.Text = "*Bạn có thể trở thành: Giám đốc điều hành, Tư vấn viên, chuyên viên nhà đất, Nhân viên marketing, Nhà phân tích tài chính.";
                label8.Text = "Những người nổi tiếng mang tính cách ENFJ: - Napoleon Bonaparte, - Julius Caesar, - Margaret Thatcher";
            }
            if (a == "ENTP")//4
            {
                label3.Text = "ENTP (Extrovert, Intuitive, Thinker, Perceiver)";
                label4.Text = "Có khoảng 3% dân số mang loại tính cách này. Bạn rất có duyên. Mọi người đều thích bạn vì bạn là người thân thiện và thoải mái. Bạn rất sáng tạo, nhưng cũng dễ thay đổi. Khả năng phân tích của bạn khá tốt.";
                label5.Text = "*Bạn nên làm những công việc: Đầu tư ngân hàng, Người viết quảng cáo, Hoạch định chiến lược, Phát thanh viên radio/TV.";
                label8.Text = "Những người nổi tiếng mang tính cách ENFJ: - Theodore Roosevelt, - Benjamin Franklin, - Thomas Edison.";
            }
            if (a == "ESFJ")//5
            {
                label3.Text = "ESFJ (Extrovert, Sensor, Feeler, Judger)";
                label4.Text = "Có khoảng 12% dân số mang tính cách này. Bạn rất năng động và tràn đầy nhiệt huyết. Tuy nhiên bạn khá nhạy cảm và dễ bị tổn thương. Bạn là người ngăn nắp và có trách nhiệm. Bạn không thích sự thay đổi.";
                label8.Text = "Những người nổi tiếng mang tính cách ENFJ: - Harry S. Truman, - Gerald Ford, - Desmond Tutu";
                label5.Text = "*Bạn có thể là một chuyên gia kinh doanh Bất động sản, Bác sĩ thú y, Giáo viên, Y tá, Nhân viên kinh doanh, Nhân viên du lịch.";
            }
            if (a == "ESFP")//6
            {
                label3.Text = "ESFP (Extrovert, Sensor, Feeler, Perceiver)";
                label4.Text = "Có khoảng 7.5% dân số mang tính cách này. Bạn khá thoải mái và khôi hài. Vì vậy đừng ngạc nhiên khi thỉnh thoảng bạn cảm thấy mình hơi bốc đồng nhé! Tuy nhiên bạn rất ham học hỏi. Bạn rất năng động và yêu các hoạt động xã hội.";
                label8.Text = "Những người nổi tiếng mang tính cách ENFJ: - Ronald Reagan, - Hugh Hefner, - Howard Schultz";
                label5.Text = "*Bạn có thể trở thành một Giáo viên mầm non, Bác sĩ chuyên khoa, Bác sĩ thú y, Nha sĩ.";
            }
            if (a == "ESTJ")//7
            {
                label8.Text = "Những người nổi tiếng mang tính cách ENFJ: - Bernard Montgomery, - Henry Ford, - George W. Bush";
                label3.Text = "ESTJ (Extrovert, Sensor, Thinker, Judger)";
                label4.Text = "Có khoảng 11,5% dân số mang tính cách này. Bạn có khuynh hướng nói thẳng những điều bạn nghĩ. Bạn rất thực tế, khó thay đổi ý kiến và nghiêm túc. Bạn yêu thích tính truyền thống và rất giỏi quyết định mọi chuyện.";
                label5.Text = "*Bạn có thể trở thành Nhân viên kinh doanh, Nhân viên bất động sản, Dược sĩ, Sĩ quan.";
            }
            if (a == "ESTP")//8
            {
                label8.Text = "Những người nổi tiếng mang tính cách ENFJ: - Ernest Hemingway, - Eddie Murphy, - Jack Nicholson";
                label3.Text = "ESTP (Extrovert, Sensor, Thinker, Perceiver)";
                label4.Text = "Có khoảng 4% dân số mang tính cách này. Bạn là người năng động, vui vẻ và quyến rũ nhưng hơi bốc đồng. Bạn thích thử thách và luôn luôn muốn học hỏi thêm nhiều điều mới lạ. Bạn cũng là người hiếu kỳ, điềm đạm và suy nghĩ lôgic.";
                label5.Text = "*Bạn có thể trở thành Nhân viên y tế, Môi giới chứng khoán, Nhân viên bảo hiểm, Kỹ sư, Nhân viên du lịch.";
            }
            if (a == "INFJ")//9
            {
                label8.Text = "Những người nổi tiếng mang tính cách ENFJ: - Martin Luther King, - Adolf Hitler., - Calvin Coolidge";
                label3.Text = "INFJ (Introvert, Intuitive, Feeler, Judger)";
                label4.Text = "Có rất ít người mang tính cách này, chỉ chiếm khoảng 1% dân số. Bạn khá sáng tạo và có khả năng làm việc độc lập. Bạn luôn luôn suy nghĩ kĩ trước khi làm bất cứ việc gì. Bạn luôn dành hết đam mê cho những gì mình làm.";
                label5.Text = "*Nghề nghiệp phù hợp với bạn là: Giáo viên, Chuyên viên huấn luyện, Biên tập viên, Giám đốc sáng tạo, Nhà văn.";
            }
            if (a == "INFP")//10
            {
                label8.Text = "Những người nổi tiếng mang tính cách ENFJ: - William Shakespeare, - J.K. Rowling, - Antoine de Saint-Exupery";
                label3.Text = "INFP (Introvert, Intuitive, Feeler, Perceiver)";
                label4.Text = "Có khoảng 4,5% dân số mang tính cách này. Bạn khá trầm lặng, kín đáo và tốt bụng. Thỉnh thoảng bạn khá nhạy cảm nên cũngdễ bị tổn thương. Bạn là người sáng tạo, độc đáo và giàu trí tưởng tượng.";
                label5.Text = "*Những nghề thích hợp với bạn: Chuyên gia nhân sự, Nhà nghiên cứu, Nhà tâm lý học, Thông dịch viên, Thủ thư, Thiết kế thời trang, Biên tập viên.";
            }
            if (a == "INTJ")//11
            {
                label8.Text = "Những người nổi tiếng mang tính cách ENFJ: - Vladimir Putin, - Augustus Caesar, - Bill Gates";
                label3.Text = "INTJ (Introvert, Intuitive, Thinker, Judger)";
                label4.Text = "Có khoảng 2% dân số mang tính cách này. Bạn thích sự độc lập và ngăn nắp. Bạn là người giàu trí tưởng tượng. Bạn có óc phân tích và lôgic. Bạn luôn khát khao nâng cao năng lực và kiến thứccủa mình. Bạn khá thận trọng và kín đáo.";
                label5.Text = "*Những nghề phù hợp với bạn: Nhà văn tự do, Hoạch định truyền thông, Kiến trúc sư, Quản trị mạng, Phát triển phần mềm.";
            }
            if (a == "INTP")//12
            {
                label8.Text = "Những người nổi tiếng mang tính cách ENFJ: - Isaac Newton,  - Albert Einstein, - James Madison";
                label3.Text = "INTP (Introvert, Intuitive, Thinker, Perceiver)";
                label4.Text = "Có khoảng 3% dân số mang tính cách INTP. Bạn khá trầm lặng. Bạn có khả năng làm việc độc lập cao. Người khác có thể kể với bạn những bí mật của họ vì bạn là người rất kín đáo. Bạn là người sáng tạo và khéo léo, nhưng bạn cũng hay thay đổi.";
                label5.Text = "*Bạn có thể phát triển nghề nghiệp của mình theo hướng: Chuyên viên phân tích tài chính, Nhà kinh tế học, Nhạc sĩ, Thiết kế Web, Xây dựng chiến lược.";
            }
            if (a == "ISFJ")//13
            {
                label8.Text = "Những người nổi tiếng mang tính cách ENFJ: - Jimmy Carter, - William Howard Taft, - Ed Bradley";
                label3.Text = "ISFJ (Introvert, Sensor, Feeler, Judger)";
                label4.Text = "Có khoảng 12.5% dân số trên thế giới mang loại tính cách này. Bạn là người cẩn thận, hiền lành và sâu sắc. Bạn làm việc chăm chỉ, có óc tổ chức và kiên quyết. Bạn rất quan tâm đến người khác. Bạn thích cuộc sống ổn định và giúp đỡ người khác.";
                label5.Text = "*Những nghề thích hợp với bạn gồm Thủ thư, Người trang trí nội thất, Chăm sóc khách hàng, Nhân viên kế toán, Giáo viên.";
            }
            if (a == "ISFP")//14
            {
                label8.Text = "Những người nổi tiếng mang tính cách ENFJ: - Donald Trump, - Elizabeth Taylor, - Michael Jackson";
                label3.Text = "ISFP (Introvert, Sensor, Feeler, Perceiver)";
                label4.Text = "Có khoảng 8% dân số mang tính cách này. Bạn rất tốt bụng và dễ cảm thông. Bạn là người chu đáo và trung thực. Bạn khá nhạy cảm nên rất dễ bị tổn thương. Tuy nhiên bạn rất dễ thích ứng với sự thay đổi.";
                label5.Text = "*Bạn có thể trở thành Nhân viên thiết kế, Chăm sóc khách hàng, Đầu bếp, Nha sĩ.";
            }
            if (a == "ISTJ")//15
            {
                label8.Text = "Những người nổi tiếng mang tính cách ENFJ: - George Washington, - Jeff Bezos, - Angela Merkel";
                label3.Text = "ISTJ (Introvert, Sensor, Thinker, Judger)";
                label4.Text = "Có đến 13% dân số trên thế giới thuộc nhóm tính cách này. Bạn là người trầm lặng. Bạn rất cẩn thận, trung thực và tỉ mỉ. Bạn thích sự ổn định, nhưng bạn cũng có thể thích nghi với sự thay đổi. Bạn làm việc chăm chỉ và rất có trách nhiệm.";
                label5.Text = "* Bạn có thể phát triển nghề nghiệp của mình theo hướng: Môi giới bất động sản, Quản lý dữ liệu, Kế toán, Thanh tra xây dựng, Quản lý văn phòng.";
            }
            if (a == "ISTP")//16
            {
                label8.Text = "Những người nổi tiếng mang tính cách ENFJ: - Tom Cruise, - Frank Zappa, - Zachary Taylor";
                label3.Text = "ISTP (Introvert, Sensor, Thinker, Perceiver)";
                label4.Text = "Có khoảng 5% dân số mang tính cách này. Bạn là một người rất thực tế. Bạn thích sự độc lập và yên tĩnh. Đôi lúc bạn cũng bốc đồng. Bạn là người theo chủ nghĩa khách quan và không dễ xúc động.";
                label5.Text = "*Những nghề thích hợp với bạn: Lập trình viên, Cảnh sát, Lính cứu hỏa, Dược sĩ.";
            }
            label6.Text = "Bạn biết đấy không có gì là hoàn hảo cả . Nhưng chúng tôi hy vọng bài trắc nghiệm này sẽ giúp bạn khám phá khả năng thật sự của mình.Từ đó bạn sẽ xác định được đâu là công việc phù hợp nhất với bạn để phát triển đúng hướng cho sự nghiệp của mình.";

        }

        private void MBTI(string a)
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
            this.Close();
            Form frm = new FormUI();
            frm.Show();
        }
    }
}

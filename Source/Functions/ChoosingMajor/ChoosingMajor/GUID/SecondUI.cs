using ChoosingMajor.DB.Interfaces;
using FX.Core;
using System.Linq;
using System.Windows.Forms;

namespace ChoosingMajor.GUID
{
    public partial class SecondUI : Form
    {
        string MaNhomNghanh = string.Empty;
        public SecondUI(string manhomnghanh)
        {
            InitializeComponent();
            MaNhomNghanh = manhomnghanh;
        }

        private void SecondUI_Load(object sender, System.EventArgs e)
        {
            INghanhService srv = IoC.Resolve<INghanhService>();
            var nganhchungs = srv.Query.Where(x => x.MaNhomNghanh == MaNhomNghanh).ToList();
            srv.UnbindSession();

            fpnParent.Controls.Clear();
            foreach (var x in nganhchungs)
            {
                Button btnNganhChung = new Button();
                btnNganhChung.Size = new System.Drawing.Size(300, 50);
                btnNganhChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10);
                btnNganhChung.Cursor = Cursors.Hand;
                btnNganhChung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btnNganhChung.Margin = new Padding(10, 0, 0, 10);
                btnNganhChung.Name = x.MaNghanh;
                btnNganhChung.Text = x.MaNghanh + " - " + x.TenNghanh;
                btnNganhChung.Click += btnNganh_Click;

                fpnParent.Controls.Add(btnNganhChung);
            }
            fpnParent.FlowDirection = FlowDirection.TopDown;
        }

        private void btnNganh_Click(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            ThirdUI frm03 = new ThirdUI(btn.Name, btn.Text);
            frm03.ShowDialog();

            btnBack.Visible = true;
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

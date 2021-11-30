using ChoosingMajor.DB.Interfaces;
using FX.Core;
using System.Linq;
using System.Windows.Forms;

namespace ChoosingMajor.GUID
{
    public partial class FirstUI : Form
    {
        public FirstUI()
        {
            InitializeComponent();
        }

        private void FirstUI_Load(object sender, System.EventArgs e)
        {
            INhomNghanhService srv = IoC.Resolve<INhomNghanhService>();
            var nhomnghanhs = srv.GetAll();
            srv.UnbindSession();

            fpnParent.Controls.Clear();
            foreach (var x in nhomnghanhs)
            {
                Button btnNhomNghanh = new Button();
                btnNhomNghanh.Size = new System.Drawing.Size(140, 100);
                btnNhomNghanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10);
                btnNhomNghanh.Cursor = Cursors.Hand;
                btnNhomNghanh.Margin = new Padding(10, 0, 0, 10);
                btnNhomNghanh.Name = x.MaNhomNghanh;
                btnNhomNghanh.Text = x.TenNhomNghanh;
                btnNhomNghanh.Click += btnNhomNghanh_Click;

                fpnParent.Controls.Add(btnNhomNghanh);
            }
        }

        private void btnNhomNghanh_Click(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            SecondUI frm02 = new SecondUI(btn.Name);
            frm02.ShowDialog();
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

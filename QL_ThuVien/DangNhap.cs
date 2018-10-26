using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ThuVien
{
    public partial class DangNhap : Form
    {
        public static string user = "";
        public static string boPhan = "";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tt = MessageBox.Show("Bạn muốn quay lại màn hình chính?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tt == System.Windows.Forms.DialogResult.Yes)
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDoiMatKhau frm = new FrmDoiMatKhau();
            frm.Show();
            this.Hide();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT COUNT(*) FROM NHANVIEN WHERE Account ='" + txtName.Text + "' AND Pass ='" + txtPass.Text + "'";
            int i = (int)DataConnection.RunsqlScalar(sql);
            if (i == 1)
            {
                string sql1 = @"SELECT BoPhan FROM NHANVIEN WHERE Account ='" + txtName.Text + "' AND Pass ='" + txtPass.Text + "'";
                string bp = (string)DataConnection.RunsqlScalar(sql1);
                boPhan = bp;
                user = txtName.Text;
                MessageBox.Show("Đăng nhập thành công!");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Đăng nhập thất bại!");
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            
        }
    }
}

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
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DangNhap frm = new DangNhap();
            frm.Show();
            this.Hide();
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT COUNT(*) FROM NHANVIEN WHERE Account ='" + txtName.Text + "' AND Pass ='" + txtOldPass.Text + "'";
            int i = (int)DataConnection.RunsqlScalar(sql);
            if (i == 1)
            {
                if (txtNewPass.Text == txtConfirm.Text)
                {
                    string strSQL = @"UPDATE dbo.NHANVIEN SET Pass ='"+txtNewPass.Text+"' WHERE Account='"+txtName.Text+"'";
                    object t = DataConnection.RunsqlQuery(strSQL);
                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
                else
                    MessageBox.Show("Xác nhận mật khẩu chưa khớp!");
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu cũ chưa đúng!");
        }
    }
}

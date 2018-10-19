using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_ThuVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void mượnSáchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
        
        private void lậpThẻĐôccGiảToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }

        private void sáchToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

            DialogResult tt = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tt == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình DEMO do nhóm 2 ĐH.TDM thực hiện! Cảm ơn bạn đã sử dụng.");
        }
    }
}

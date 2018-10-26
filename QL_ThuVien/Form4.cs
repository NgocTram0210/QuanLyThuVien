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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private string strSQL = "";
        private DataSet ds = null;
        private object t = null;
        private object m = new object();

        private void displayData()
        {
            strSQL = @"select * from NHANVIEN";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            dgvNhanVien.DataSource = ds.Tables[0];

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            strSQL = @"select * from NHANVIEN";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxMaNV.DataSource = ds.Tables[0];
            cbxMaNV.DisplayMember = "MaNV";
            cbxMaNV.ValueMember = "MaNV";
            dgvNhanVien.DataSource = ds.Tables[0];

            strSQL = @"select * from BANGCAP";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxBangcap.DataSource = ds.Tables[0];
            cbxBangcap.DisplayMember = "TenBC";
            cbxBangcap.ValueMember = "MaBC";

            strSQL = @"select * from CHUCVU";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxChucvu.DataSource = ds.Tables[0];
            cbxChucvu.DisplayMember = "TenCV";
            cbxChucvu.ValueMember = "MaCV";

            strSQL = @"select * from BOPHAN";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxBophan.DataSource = ds.Tables[0];
            cbxBophan.DisplayMember = "TenBP";
            cbxBophan.ValueMember = "MaBP";
        }

        private void dgvNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            cbxMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            dtNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtDiachi.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtDienthai.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtAccount.Text = dgvNhanVien.CurrentRow.Cells[9].Value.ToString();
            txtPass.Text = dgvNhanVien.CurrentRow.Cells[10].Value.ToString();

            strSQL = @"Select tenBC from BANGCAP where MaBC='" + dgvNhanVien.CurrentRow.Cells[6].Value.ToString() + "'";
            m = DataConnection.RunsqlScalar(strSQL);
            cbxBangcap.Text = m.ToString();

            strSQL = @"Select TenBP from BOPHAN where MaBP='" + dgvNhanVien.CurrentRow.Cells[7].Value.ToString() + "'";
            m = DataConnection.RunsqlScalar(strSQL);
            cbxBophan.Text = m.ToString();

            strSQL = @"Select TenCV from CHUCVU where MaCV='" + dgvNhanVien.CurrentRow.Cells[8].Value.ToString() + "'";
            m = DataConnection.RunsqlScalar(strSQL);
            cbxChucvu.Text = m.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Muốn xóa Nhân Viên có mã là " + cbxMaNV.Text + " phải không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                strSQL = @"delete from NHANVIEN where MaNV ='" + cbxMaNV.Text + "'";
                t = DataConnection.RunsqlQuery(strSQL);
                displayData();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult tt = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tt == System.Windows.Forms.DialogResult.Yes)
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (cbxMaNV.Text == "" || txtHoten.Text == "")
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin.");
            else
            {
                string bc, bp, cv, d;
                bp = cbxBophan.SelectedValue.ToString();
                bc = cbxBangcap.SelectedValue.ToString();
                cv = cbxChucvu.SelectedValue.ToString();
                d = dtNgaySinh.Value.ToString("yyyy/MM/dd");

                strSQL = @"insert into NHANVIEN values ('" + cbxMaNV.Text + "',N'" + txtHoten.Text + "','" + d + "',N'" + txtDiachi.Text + "','" + txtEmail.Text + "','" + txtDienthai.Text + "','" + bc + "','" + bp + "','" + cv + "','"+txtAccount.Text+"','"+txtPass.Text+"')";
                t = DataConnection.RunsqlQuery(strSQL);
                displayData();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string bc, bp, cv;
            bp = cbxBophan.SelectedValue.ToString();
            bc = cbxBangcap.SelectedValue.ToString();
            cv = cbxChucvu.SelectedValue.ToString();

            strSQL = @"update NHANVIEN set HoTen=N'" +txtHoten.Text+ "',NgaySinh='" +dtNgaySinh.Value.ToString("yyyy/MM/dd") + "',DiaChi=N'" 
                +txtDiachi.Text +"',DienThoai='" + txtDienthai.Text + "',Email='" + txtEmail.Text + "',BoPhan='" + bp + "',ChucVu='" + cv
                + "',BangCap='" + bc + "',Account='"+txtAccount.Text+"', Pass='"+txtPass.Text+"' where MaNV='"+cbxMaNV.Text+"'";

            t = DataConnection.RunsqlQuery(strSQL);
            displayData();
        }

        private void txtDienthai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    
}

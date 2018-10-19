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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private string strSQL = "";
        private DataSet ds = null;
        private object t = null;
        private object m = new object();

        private void displayData()
        {
            strSQL = @"select * from SACH";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            dgvSach.DataSource = ds.Tables[0];

        }
        private void Form5_Load(object sender, EventArgs e)
        {
            strSQL = @"select * from SACH";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxMaSach.DataSource = ds.Tables[0];
            cbxMaSach.DisplayMember = "MaSach";
            cbxMaSach.ValueMember = "MaSach";
            dgvSach.DataSource = ds.Tables[0];

            strSQL = @"select * from THELOAISACH";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxLoai.DataSource = ds.Tables[0];
            cbxLoai.DisplayMember = "TenTheLoai";
            cbxLoai.ValueMember = "MaLoai";

            strSQL = @"select * from NHANVIEN where BoPhan ='BP2'";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxNVNhan.DataSource = ds.Tables[0];
            cbxNVNhan.DisplayMember = "HoTen";
            cbxNVNhan.ValueMember = "MaNV";
        }

        private void dgvSach_MouseClick(object sender, MouseEventArgs e)
        {
            cbxMaSach.Text = dgvSach.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvSach.CurrentRow.Cells[1].Value.ToString();
            txtTacgia.Text = dgvSach.CurrentRow.Cells[3].Value.ToString();
            txtNamXB.Text = dgvSach.CurrentRow.Cells[4].Value.ToString();
            txtNXB.Text = dgvSach.CurrentRow.Cells[5].Value.ToString();
            dtNgaynhap.Text = dgvSach.CurrentRow.Cells[6].Value.ToString();
            txtTrigia.Text = dgvSach.CurrentRow.Cells[7].Value.ToString();

            strSQL = @"Select TenTheLoai from THELOAISACH where MaLoai='" + dgvSach.CurrentRow.Cells[2].Value.ToString() + "'";
            m = DataConnection.RunsqlScalar(strSQL);
            cbxLoai.Text = m.ToString();

            strSQL = @"Select HoTen from NHANVIEN where MaNV='" + dgvSach.CurrentRow.Cells[8].Value.ToString() + "'";
            m = DataConnection.RunsqlScalar(strSQL);
            cbxNVNhan.Text = m.ToString();
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

        private void btXoa_Click(object sender, EventArgs e)
        {
            strSQL = @"select MaPM from CTMUONSACH where SachMuon='"+ cbxMaSach.Text+"'";
            m = DataConnection.RunsqlScalar(strSQL);
            if (m != null)
                MessageBox.Show("Sách còn đang mượn.");
            else
            {
                DialogResult result = MessageBox.Show("Bạn Muốn xóa cuốn sách có mã là " + cbxMaSach.Text + " phải không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    strSQL = @"delete from THONGKEMUONSACH where MaSach ='" + cbxMaSach.Text + "'";
                    t = DataConnection.RunsqlQuery(strSQL);

                    strSQL = @"delete from SACH where MaSach ='" + cbxMaSach.Text + "'";
                    t = DataConnection.RunsqlQuery(strSQL);
                    displayData();
                }
            }
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            if (cbxMaSach.Text == "" || txtTrigia.Text == "" || txtNamXB.Text =="" || txtTen.Text=="")
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin.");
            if (int.Parse(txtNamXB.Text) > 2017 || int.Parse(txtNamXB.Text) < 2009)
                MessageBox.Show("Năm xuất bản không hợp lệ.");
            else
            {
                string bc, bp, d;
                bc = cbxLoai.SelectedValue.ToString();
                bp = cbxNVNhan.SelectedValue.ToString();
                d = dtNgaynhap.Value.ToString("yyyy/MM/dd");

                strSQL = @"insert into SACH values ('" + cbxMaSach.Text + "','" + txtTen.Text + "','" + bc + "','" + txtTacgia.Text + "','" + txtNamXB.Text + "','" + txtNXB.Text + "','" + d + "','" + txtTrigia.Text + "','" + bp + "')";
                t = DataConnection.RunsqlQuery(strSQL);
                displayData();
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNamXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNamXB.MaxLength = 4;
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTrigia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string l, nv;
            l = cbxLoai.SelectedValue.ToString();
            nv = cbxNVNhan.SelectedValue.ToString();

            strSQL = @"update Sach set TenSach='"+txtTen.Text+"', NamXB='"+txtNamXB.Text+ "', Loai='" +l + "', TacGia='" + txtTacgia.Text
                + "', NhaXB='" + txtNXB.Text + "', NgayNhap='" + dtNgaynhap.Value.ToString("yyyy/MM/dd") + "', TriGia='" + txtTrigia.Text
                + "', NVTiepNhan='" + nv +"' where MaSach='"+cbxMaSach.Text+"'";
            t = DataConnection.RunsqlQuery(strSQL);
            displayData();
        }
    }
}

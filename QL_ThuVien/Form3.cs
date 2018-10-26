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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private string strSQL = "";
        private DataSet ds = null;
        private object t = null;
        private object m = new object();

        private void displayData()
        {
            strSQL = @"select * from DOCGIA";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            dgvDG.DataSource = ds.Tables[0];

        }
        private void Form3_Load(object sender, EventArgs e)
        {

            strSQL = @"select * from DOCGIA";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxMaDG.DataSource = ds.Tables[0];
            cbxMaDG.DisplayMember = "MaDG";
            cbxMaDG.ValueMember = "MaDG";
            dgvDG.DataSource = ds.Tables[0];

            strSQL = @"select * from LOAIDOCGIA";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxLoai.DataSource = ds.Tables[0];
            cbxLoai.DisplayMember = "LoaiDG";
            cbxLoai.ValueMember = "MaDG";

            strSQL = @"select * from NHANVIEN where BoPhan ='BP1'";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxNVLap.DataSource = ds.Tables[0];
            cbxNVLap.DisplayMember = "HoTen";
            cbxNVLap.ValueMember = "MaNV";
        }

        private void dgvDG_MouseClick(object sender, MouseEventArgs e)
        {
            cbxMaDG.Text = dgvDG.CurrentRow.Cells[0].Value.ToString();

            txtHoten.Text = dgvDG.CurrentRow.Cells[1].Value.ToString();
            dtNgaySinh.Text = dgvDG.CurrentRow.Cells[2].Value.ToString();
            txtDiachi.Text = dgvDG.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvDG.CurrentRow.Cells[4].Value.ToString();
            dtNgayLap.Text = dgvDG.CurrentRow.Cells[6].Value.ToString();

            strSQL = @"Select LoaiDG from LOAIDOCGIA where MaDG='" + dgvDG.CurrentRow.Cells[5].Value.ToString() + "'";
            m = DataConnection.RunsqlScalar(strSQL);
            cbxLoai.Text = m.ToString();

            strSQL = @"Select HoTen from NHANVIEN where MaNV='" + dgvDG.CurrentRow.Cells[7].Value.ToString() + "'";
            m = DataConnection.RunsqlScalar(strSQL);
            cbxNVLap.Text = m.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            strSQL = @"select * from CTMUONSACH where MaDG='"+cbxMaDG.Text+"'";
            m = DataConnection.RunsqlScalar(strSQL);
            if (m != null)
                MessageBox.Show("Độc Giả chưa trả hết sách.");
            else
            {

                DialogResult result = MessageBox.Show("Bạn Muốn xóa Độc Giả có mã là " + cbxMaDG.Text + " phải không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    strSQL = @"select MaSach from THONGKEMUONSACH,MUONSACH where MaDG='" + cbxMaDG.Text + "' and MaPM=MaPhieuMuon";
                    m = DataConnection.RunsqlScalar(strSQL);
                    if (m != null)
                    {
                        strSQL = @"delete from THONGKEMUONSACH where MaPM =( select MaPhieumuon from MUONSACH where MaDG='" + cbxMaDG.Text + "')";
                        t = DataConnection.RunsqlQuery(strSQL);

                        strSQL = @"delete from MUONSACH where MaDG ='" + cbxMaDG.Text + "'";
                        t = DataConnection.RunsqlQuery(strSQL);
                    }

                    strSQL = @"delete from DOCGIA where MaDG ='" + cbxMaDG.Text + "'";
                    t = DataConnection.RunsqlQuery(strSQL);
                    displayData();
                }
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

        private void btLapthe_Click(object sender, EventArgs e)
        {
            if (cbxMaDG.Text == "" || txtHoten.Text == "")
                MessageBox.Show("Bạn hãy nhập đủ thông tin.");
            else
            {
                string bc, bp, d, dt;
                bc = cbxLoai.SelectedValue.ToString();
                bp = cbxNVLap.SelectedValue.ToString();
                d = dtNgaySinh.Value.ToString("yyyy/MM/dd");
                dt = dtNgayLap.Value.ToString("yyyy/MM/dd");

                strSQL = @"insert into DOCGIA values ('" + cbxMaDG.Text + "',N'" + txtHoten.Text + "','" + d + "',N'" + txtDiachi.Text + "','" + txtEmail.Text + "','" + bc + "','" + dt + "','" + bp + "')";
                t = DataConnection.RunsqlQuery(strSQL);
                displayData();
            }
        }
        

        private void btSua_Click(object sender, EventArgs e)
        {
            string nl, nv;
            nl = cbxLoai.SelectedValue.ToString() ;
            nv = cbxNVLap.SelectedValue.ToString();

            strSQL = @"update DOCGIA set HoTen=N'"+ txtHoten.Text +"', NgaySinh='"+dtNgaySinh.Value.ToString("yyyy/MM/dd")+"', DiaChi=N'"
                +txtDiachi.Text+"', Email='"+txtEmail.Text+"', LoaiDG='"+nl+"', NgayLap='"+ dtNgayLap.Value.ToString("yyyy/MM/dd") 
                + "', NVLap='"+nv+"' where MaDG='"+cbxMaDG.Text+"'";
            t = DataConnection.RunsqlQuery(strSQL);
            displayData();
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string strSQL = "";
        private DataSet ds = null;
        string dl;
        private object t = null;
        private object m = new object();

        private void displayData()
        {
            strSQL = @"select MaPM, HoTen, TenSach, NgayMuon,Han from CTMUONSACH a left join DOCGIA b on a.MaDG=b.MaDG left join SACH on SachMuon=MaSach";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxPML.DataSource = ds.Tables[0];
            dgvShow.DataSource = ds.Tables[0];

        }

        private void display()
        {
            strSQL = @"select * from MUONSACH";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxPML.DataSource = ds.Tables[0];
            dgvLapPM.DataSource = ds.Tables[0];
        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            dl = cbxDG.SelectedValue.ToString();
            strSQL = @"select * from MUONSACH where MaDG = '" + dl + "'";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            dgvLapPM.DataSource = ds.Tables[0];
        }

        private void btReset_Click_1(object sender, EventArgs e)
        {
            display();
        }

        private void btLapPM_Click_1(object sender, EventArgs e)
        {
            string bc;
            bc = cbxDG.SelectedValue.ToString();

            string d = dtNgaymuon.Value.ToString("yyyy/MM/dd");
            strSQL = @"insert into MUONSACH values ('" + cbxPML.Text + "','" + bc + "','" + d + "')";
            t = DataConnection.RunsqlQuery(strSQL);
            display();

            strSQL = @"select * from MUONSACH ";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxPMS.DataSource = ds.Tables[0];
            cbxPMS.DisplayMember = "MaPhieuMuon";
            cbxPMS.ValueMember = "MaPhieuMuon";
        }

        private void btMuon_Click_1(object sender, EventArgs e)
        {
            strSQL = @"select MaPM from CTMUONSACH where SachMuon='"+cbxSach.SelectedValue.ToString()+"'";
            m = DataConnection.RunsqlScalar(strSQL);
            if (m != null)
                MessageBox.Show("Sách đã có người mượn.");
            else
            {
                string bc;
                strSQL = @"select HoTen from MUONSACH a,DOCGIA b where a.MADG=b.MaDG and MaPhieuMuon = '" + cbxPMS.Text + "'";
                m = DataConnection.RunsqlScalar(strSQL);
                cbxDG.Text = m.ToString();
                bc = cbxDG.SelectedValue.ToString();

                strSQL = @"select NGAYMUON from MUONSACH where MaPhieuMuon = '" + cbxPMS.Text + "'";
                m = DataConnection.RunsqlScalar(strSQL);
                dtNgaymuon.Text = m.ToString();

                string bp;
                bp = cbxSach.SelectedValue.ToString();
                strSQL = @"insert into THONGKEMUONSACH values ('" + cbxPMS.Text + "','" + bp + "')";
                t = DataConnection.RunsqlQuery(strSQL);

                strSQL = @"insert into CTMUONSACH values ('" + cbxPMS.Text + "','" + bc + "','" + bp + "','" + dtNgaymuon.Value.ToString("yyyy/MM/dd") + "',null)";
                t = DataConnection.RunsqlQuery(strSQL);
                displayData();
            }
        }

        private void btTraSach_Click_1(object sender, EventArgs e)
        {
            string bc;
            bc = cbxSach.SelectedValue.ToString();

            strSQL = @"delete from CTMUONSACH where SachMuon='" + bc + "' and MaPM='"+cbxPMS.Text+"'";
            t = DataConnection.RunsqlQuery(strSQL);
            displayData();
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult tt = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tt == System.Windows.Forms.DialogResult.Yes)
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            strSQL = @"select MaPM, HoTen, TenSach, NgayMuon,Han from CTMUONSACH a left join DOCGIA b on a.MaDG=b.MaDG left join SACH on SachMuon=MaSach";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxPMS.DataSource = ds.Tables[0];
            dgvShow.DataSource = ds.Tables[0];

            strSQL = @"select * from MUONSACH";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxPML.DataSource = ds.Tables[0];
            cbxPML.DisplayMember = "MaPhieuMuon";
            cbxPML.ValueMember = "MaPhieuMuon";
            dgvLapPM.DataSource = ds.Tables[0];



            strSQL = @"select * from MUONSACH ";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxPMS.DataSource = ds.Tables[0];
            cbxPMS.DisplayMember = "MaPhieuMuon";
            cbxPMS.ValueMember = "MaPhieuMuon";

            strSQL = @"select * from SACH";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxSach.DataSource = ds.Tables[0];
            cbxSach.DisplayMember = "TenSach";
            cbxSach.ValueMember = "MaSach";

            strSQL = @"select * from DOCGIA ";
            ds = new DataSet();
            ds = DataConnection.GetDataSet(strSQL);
            cbxDG.DataSource = ds.Tables[0];
            cbxDG.DisplayMember = "HoTen";
            cbxDG.ValueMember = "MaDG";


        }

        private void dgvLapPM_MouseClick_1(object sender, MouseEventArgs e)
        {
            cbxPML.Text = dgvLapPM.CurrentRow.Cells[0].Value.ToString();

            dtNgaymuon.Text = dgvLapPM.CurrentRow.Cells[2].Value.ToString();

            strSQL = @"Select HoTen from DOCGIA where MaDG='" + dgvLapPM.CurrentRow.Cells[1].Value.ToString() + "'";
            m = DataConnection.RunsqlScalar(strSQL);
            cbxDG.Text = m.ToString();
        }

        private void dgvShow_MouseClick_1(object sender, MouseEventArgs e)
        {
            cbxPMS.Text = dgvShow.CurrentRow.Cells[0].Value.ToString();
            cbxSach.Text = dgvShow.CurrentRow.Cells[2].Value.ToString();
            cbxDG.Text = dgvShow.CurrentRow.Cells[1].Value.ToString();
            dtNgaymuon.Text = dgvShow.CurrentRow.Cells[3].Value.ToString();
            
    }
}
}

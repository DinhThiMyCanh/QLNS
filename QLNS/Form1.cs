using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QLNS
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder buider;
        string st = @"Data Source=CANH-DHQN\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        #region cac phuong thuc
        //Lay du lieu phong ban
        public void loadPB()
        {
            string sql = "select * from DMPHONG";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds,"PHONGBAN");

            cboPhongBan.DataSource = ds.Tables["PHONGBAN"];
            cboPhongBan.DisplayMember = "TenPhong";
            cboPhongBan.ValueMember = "MaPhong";
        }
        //Lay du lieu DSNV
        public void loadData()
        {
            string sql = "select * from DSNV";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "NHANVIEN");

            data.DataSource = ds.Tables["NHANVIEN"];
        }
        //Kiểm tra mã nhân viên có bị trùng hay không
        public int ktraMaNV(string ma)
        {
            conn.Open();
            string sql = string.Format("select count(*) from DSNV where maNV ='{0}'",ma.Trim());
            SqlCommand cmd = new SqlCommand(sql, conn);
            int sl = (int)cmd.ExecuteScalar();
            conn.Close();
            return sl;
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(st);
            ds = new DataSet();
            loadPB();
            loadData();
            buider = new SqlCommandBuilder(da);
        }

        private void txtTen_Click(object sender, EventArgs e)
        {
            txtTen.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from DSNV where HoTen Like N'%{0}'",txtTen.Text);
            da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            data.DataSource = dt;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string sql = @"select B.TenPhong, count(A.MaPhong) as SoLuongNV 
                from DSNV as A, DMPHONG as B 
                where A.MaPhong = B.MaPhong group By B.TenPhong";
            da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            data.DataSource = dt;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtMaNV.Clear();
            txtHSL.Clear();

            txtHoTen.Focus();

            data.DataSource = ds.Tables["NHANVIEN"];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ktraMaNV(txtMaNV.Text) == 0)
            {
                DataTable dt = ds.Tables["NHANVIEN"];
                DataRow r = dt.NewRow();
                r[0] = txtMaNV.Text;
                r[1] = txtHoTen.Text;
                r[2] = cboPhongBan.SelectedValue.ToString();
                r[3] = float.Parse(txtHSL.Text);
                r[4] = "NV";
                dt.Rows.Add(r);

                da.Update(ds, "NHANVIEN");
            }
            else
                MessageBox.Show("Bị trùng mã nhân viên");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int i = data.CurrentCell.RowIndex;//Chọn 1 dòng trên dataGridview
                DataTable dt = ds.Tables["NHANVIEN"];
                dt.Rows[i].Delete();

                da.Update(ds, "NHANVIEN");
            }    

           
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = data.CurrentCell.RowIndex;//Chọn 1 dòng trên dataGridview
            txtMaNV.Text = data.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = data.Rows[i].Cells[1].Value.ToString();
            cboPhongBan.SelectedValue = data.Rows[i].Cells[2].Value.ToString();
            txtHSL.Text = data.Rows[i].Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int i = data.CurrentCell.RowIndex;//Chọn 1 dòng trên dataGridview
            DataTable dt = ds.Tables["NHANVIEN"];
            DataRow r = dt.Rows[i];
            r[0] = txtMaNV.Text;
            r[1] = txtHoTen.Text;
            r[2] = cboPhongBan.SelectedValue.ToString();
            r[3] = float.Parse(txtHSL.Text);
            r[4] = "NV";

            da.Update(ds, "NHANVIEN");

        }
    }
}


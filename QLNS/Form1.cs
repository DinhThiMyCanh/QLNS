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
        string st = @"Data Source=CANH-DHQN\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
        SqlConnection cnn;
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }
        //Phương thức load dữ liệu lên cboPhongBan
        public void loadPB()
        {
            //Bước 2: dùng DataAdapter để lấy dữ liệu từ Database
            string sql = "select * from DMPHONG";
            da = new SqlDataAdapter(sql,cnn);
            //Bước 3: Đổ dữ liệu lên Dataset
            da.Fill(ds,"PhongBan");
            //Bước 4: Thao tác dữ liệu trên Dataset
            cboPhongBan.DataSource = ds.Tables["PhongBan"];
            cboPhongBan.ValueMember = "MaPhong";
            cboPhongBan.DisplayMember = "TenPhong";

        }
        //Phương thức load dữ liệu lên DataGridview
        public void loadData()
        {
            string sql = "select * from DSNV";
            da = new SqlDataAdapter(sql,cnn);
            da.Fill(ds, "NhanVien");
            data.DataSource = ds.Tables["NhanVien"];

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Bước 1: kết nối đến CSDL
            cnn = new SqlConnection(st);
            ds = new DataSet();
            loadPB();
            loadData();
        }

        private void txtTen_Click(object sender, EventArgs e)
        {
            txtTen.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from DSNV where HoTen Like N'%{0}'",txtTen.Text);
            da = new SqlDataAdapter(sql, cnn);
            // da.Fill(ds, "NhanVien2");
            DataTable dt = new DataTable();
            da.Fill(dt);
            data.DataSource = dt;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"select B.TenPhong, count(A.maNV) as SoLuong
            from DSNV as A, DMPHONG as B 
            where A.MaPhong =B.MaPhong group by B.TenPhong");
            da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data.DataSource = dt;
        }
    }
}


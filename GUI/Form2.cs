using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Data.SqlClient;



namespace GUI
{
    public partial class Form2 : Form
    {
      
        private HangHoaBUS HangHoaBUS = null;
        string soNo = "0";
        int tongTien = 0;
        public Form2()
        {


            InitializeComponent();
            this.HangHoaBUS = HangHoaBUSImpl.Instance;
            fillcomboboxTenKH();
            fillcomboboxTenSP();   
        }
       
        private void Form2_Load_1(object sender, EventArgs e)
        {
            
            tbNgayBan.Text = DateTime.Now.ToString("dd-MM-yyyy");
            dataGridView1.DataSource = HangHoaBUS.GetData();
            
        }
        public void fillcomboboxTenKH()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KE9BVRA\SQLEXPRESS; ;Initial Catalog = QuanLyCuaHangPhanBon; User = sa; Password=sa");
            string sql = "select * from dbo.KhachHang";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(1);
                    cbTenKH.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void fillcomboboxTenSP()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KE9BVRA\SQLEXPRESS; ;Initial Catalog = QuanLyCuaHangPhanBon; User = sa; Password=sa");
            string sql = "select * from dbo.HangHoa where TinhTrang = 'True'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader data;
            try
            {
                con.Open();
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    string sname = data.GetString(1);
                    cbTenSP.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cbTaoMa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTaoMa.Checked == true)
            {
                string maHd = taoMaHoaDon();
                tbMaHD.Text = maHd;
            }


        }

        private string taoMaHoaDon()
        {
            string[] arrString = { "A", "B", "C", "D", "E", "F", "1", "2", "3", "4" };
            Random rdNum = new Random();
            string rdString = "";
            for (int i = 0; i <= 5; i++)
            {
                int num = rdNum.Next(0, 10);
                rdString += arrString[num];
            }
            return rdString;
        }

       
        private void cbTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KE9BVRA\SQLEXPRESS; ;Initial Catalog = QuanLyCuaHangPhanBon; User = sa; Password=sa");
            string sql = "select * from dbo.KhachHang where TenKH = N'" + cbTenKH.Text + "' ;";
         
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader data;
            try
            {
                con.Open();
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    string maKH = data.GetInt32(0).ToString();
                    string DiaChi = data.GetString(3);
                    string SDT = data.GetString(2);
                    string SoNo = data.GetDouble(4).ToString();


                    tbMaKH.Text = maKH;
                    tbDiaChi.Text = DiaChi;
                    tbSDT.Text = SDT;
                    soNo = SoNo;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KE9BVRA\SQLEXPRESS; ;Initial Catalog = QuanLyCuaHangPhanBon; User = sa; Password=sa");

            string sql = "select * from dbo.HangHoa where TenHH = N'" + cbTenSP.Text + "' ;";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dataa;
            try
            {
                con.Open();
                dataa = cmd.ExecuteReader();
                while (dataa.Read())
                {
                    string maHH = dataa.GetInt32(0).ToString();
                    string tenHH = dataa.GetString(1);
                    string DonViTinh = dataa.GetString(2);
                    string GiaBan = dataa.GetDouble(3).ToString();
                    string SoLuong = dataa.GetInt32(5).ToString();



                    tbMaSp.Text = maHH;
                    tbTenSP.Text = tenHH;
                    tbDonVi.Text = DonViTinh;
                    tbGiaBan.Text = GiaBan;
                    tbSLTon.Text = SoLuong;
                    tbSL.Text = "0";
                    tbCK.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void tbSL_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int sl = Convert.ToInt32(tbSL.Text);
                int donGia = Convert.ToInt32(tbGiaBan.Text);
                int ck = (Convert.ToInt32(tbCK.Text) * donGia) * sl / 100;
                int total = sl * donGia - ck;
                tbTamTinh.Text = total.ToString();
            }
            catch
            {

            }

        }

        private void tbCK_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sl = Convert.ToInt32(tbSL.Text);
                int donGia = Convert.ToInt32(tbGiaBan.Text);
                int ck = (Convert.ToInt32(tbCK.Text) * donGia)*sl / 100;
                int total = sl * donGia - ck;
                tbTamTinh.Text = total.ToString();
            }
            catch
            {

            }

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
           
            int sl = Convert.ToInt32( tbSL.Text);
            updateData(tbMaSp.Text, sl);
            dataGridView1.DataSource = HangHoaBUS.GetData();

            addToCart(tbMaSp.Text, tbSL.Text, tbGiaBan.Text, tbCK.Text,tbMaKH.Text,5,tbNgayBan.Text,0);

            tongTien = tongTien + Convert.ToInt32(tbTamTinh.Text);
            tbTongTien.Text = tongTien.ToString();


        }
        private int getMaHD(string TenSp)
        {
            int MaHD = 0 ;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KE9BVRA\SQLEXPRESS; ;Initial Catalog = QuanLyCuaHangPhanBon; User = sa; Password=sa");
            string sql = "SELECT MAX(MaHDB)  FROM dbo.HoaDonBanHang; ";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dataa;
            try
            {
                con.Open();
                dataa = cmd.ExecuteReader();
                while (dataa.Read())
                {
                  MaHD = dataa.GetInt32(0);
           
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return MaHD;

        }
        private void addToCart(string TenSP, string Sl, string DonGia, string Ck,string KhachHang, int NhanVienLap, string NgayLap, int TienTra)
        {
            string maHD = (getMaHD(TenSP)+1).ToString() ;
        
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KE9BVRA\SQLEXPRESS; ;Initial Catalog = QuanLyCuaHangPhanBon; User = sa; Password=sa");
            using (SqlCommand command = con.CreateCommand())
            {
                command.CommandText = "insert into dbo.HoaDonBanHang(MaHDB,KhachHang,NhanVienLap,NgayLap,TienTra,TinhTrang) values('" + maHD + "','" + KhachHang + "','" + NhanVienLap + "','" + NgayLap + "','" + TienTra + "', 'True')";

                con.Open();

                command.ExecuteNonQuery();

                con.Close();
            }

            using (SqlCommand command = con.CreateCommand())
            {
                command.CommandText = "insert into dbo.CTHDBanHang(MaHDB,SanPham,SL,DonGia,CK,TinhTrang) values('"+maHD+"','"+TenSP+"','"+Sl+"','"+DonGia+"','"+Ck+"', 'True')";

                con.Open();

                command.ExecuteNonQuery();

                con.Close();
            }
           
        }
        private void updateData(string maSP, int Sl)
        {
            int soLuong = Convert.ToInt32(tbSLTon.Text) - (Sl);
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KE9BVRA\SQLEXPRESS; ;Initial Catalog = QuanLyCuaHangPhanBon; User = sa; Password=sa");
            using (SqlCommand command = con.CreateCommand())
            {
                command.CommandText = "UPDATE dbo.HangHoa SET SoLuong = @sl  Where MaHH = @maSP";


                command.Parameters.AddWithValue("@sl", soLuong);
                command.Parameters.AddWithValue("@maSP", maSP);


                con.Open();

                command.ExecuteNonQuery();

                con.Close();

            }
            tbSLTon.Text = soLuong.ToString();

        }

 

        public string _cbTenKH
        {
            get { return cbTenKH.Text; }
        }

        public string _tbSoNo
        {
            get { return soNo; }
        }

        public string _tbDiaChi
        {
            get { return tbDiaChi.Text; }
        }

        public string _tbSDT
        {
            get { return tbSDT.Text; }
        }
        public string _tbMHD
        {
            get { return tbMaHD.Text; }
        }
        public string _tbNgay
        {
            get { return tbNgayBan.Text; }
        }

        public string _tongTien
        {
            get { return tbTongTien.Text; }
        }

        public string _returnTongTien
        {
            set { tbTongTien.Text = value; }
        }

        private void tbNgayBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan thanhToan = new ThanhToan();
            thanhToan.FormClosed += new FormClosedEventHandler(child_FormClosed);
            thanhToan._cbTenKH1 = _cbTenKH;
            thanhToan._tbSoNo = _tbSoNo;
            thanhToan._tbDiaChi = _tbDiaChi;
            thanhToan._tbSDT = _tbSDT;

            thanhToan._tbMHD = _tbMHD;
            thanhToan._tbNgay = _tbNgay;    
            thanhToan._tongTien = _tongTien;

            thanhToan.ShowDialog();
        }
        void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when child form is closed, this code is executed
            this.tongTien = 0;
            this.tbTongTien.Text = "0";
            this.tbCK.Text = "0";
            this.tbSL.Text = "0";
        }

        private void tbTongTien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

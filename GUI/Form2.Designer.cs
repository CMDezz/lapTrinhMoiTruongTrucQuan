
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    partial class Form2
    {
     
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNgayBan = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.cbTenKH = new System.Windows.Forms.ComboBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.cbTaoMa = new System.Windows.Forms.CheckBox();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.lbMaHoaDon = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTamTinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenSP2 = new System.Windows.Forms.Label();
            this.tbCK = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbMaSp = new System.Windows.Forms.TextBox();
            this.tbSLTon = new System.Windows.Forms.TextBox();
            this.lbSLTon = new System.Windows.Forms.Label();
            this.tbGiaBan = new System.Windows.Forms.TextBox();
            this.tbTenSP = new System.Windows.Forms.TextBox();
            this.lbGiaBan = new System.Windows.Forms.Label();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.lbMaSP = new System.Windows.Forms.Label();
            this.tbDonVi = new System.Windows.Forms.TextBox();
            this.lbDonVi = new System.Windows.Forms.Label();
            this.lbCK = new System.Windows.Forms.Label();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.lbSL = new System.Windows.Forms.Label();
            this.cbTenSP = new System.Windows.Forms.ComboBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 397);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 231);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNgayBan);
            this.groupBox1.Controls.Add(this.tbSDT);
            this.groupBox1.Controls.Add(this.tbDiaChi);
            this.groupBox1.Controls.Add(this.tbMaKH);
            this.groupBox1.Controls.Add(this.cbTenKH);
            this.groupBox1.Controls.Add(this.lbMaNV);
            this.groupBox1.Controls.Add(this.lbDiaChi);
            this.groupBox1.Controls.Add(this.lbTenKH);
            this.groupBox1.Controls.Add(this.lbMaKH);
            this.groupBox1.Controls.Add(this.cbTaoMa);
            this.groupBox1.Controls.Add(this.tbMaNV);
            this.groupBox1.Controls.Add(this.lbSDT);
            this.groupBox1.Controls.Add(this.tbTenNV);
            this.groupBox1.Controls.Add(this.lbTenNV);
            this.groupBox1.Controls.Add(this.lbNgay);
            this.groupBox1.Controls.Add(this.tbMaHD);
            this.groupBox1.Controls.Add(this.lbMaHoaDon);
            this.groupBox1.Location = new System.Drawing.Point(28, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 165);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbNgayBan
            // 
            this.tbNgayBan.Location = new System.Drawing.Point(131, 52);
            this.tbNgayBan.Name = "tbNgayBan";
            this.tbNgayBan.ReadOnly = true;
            this.tbNgayBan.Size = new System.Drawing.Size(143, 20);
            this.tbNgayBan.TabIndex = 17;
            this.tbNgayBan.Text = "0";
            this.tbNgayBan.TextChanged += new System.EventHandler(this.tbNgayBan_TextChanged);
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(577, 125);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.ReadOnly = true;
            this.tbSDT.Size = new System.Drawing.Size(143, 20);
            this.tbSDT.TabIndex = 16;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(577, 90);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.ReadOnly = true;
            this.tbDiaChi.Size = new System.Drawing.Size(143, 20);
            this.tbDiaChi.TabIndex = 15;
            // 
            // tbMaKH
            // 
            this.tbMaKH.Location = new System.Drawing.Point(577, 52);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.ReadOnly = true;
            this.tbMaKH.Size = new System.Drawing.Size(143, 20);
            this.tbMaKH.TabIndex = 14;
            this.tbMaKH.TextChanged += new System.EventHandler(this.tbMaKH_TextChanged);
            // 
            // cbTenKH
            // 
            this.cbTenKH.FormattingEnabled = true;
            this.cbTenKH.Location = new System.Drawing.Point(577, 16);
            this.cbTenKH.Name = "cbTenKH";
            this.cbTenKH.Size = new System.Drawing.Size(143, 21);
            this.cbTenKH.TabIndex = 13;
            this.cbTenKH.SelectedIndexChanged += new System.EventHandler(this.cbTenKH_SelectedIndexChanged);
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(30, 128);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(75, 13);
            this.lbMaNV.TabIndex = 12;
            this.lbMaNV.Text = "Mã Nhân Viên";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(467, 93);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(49, 13);
            this.lbDiaChi.TabIndex = 11;
            this.lbDiaChi.Text = "Địa chỉ : ";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Location = new System.Drawing.Point(467, 19);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(95, 13);
            this.lbTenKH.TabIndex = 10;
            this.lbTenKH.Text = "Tên khách hàng : ";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(467, 55);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(91, 13);
            this.lbMaKH.TabIndex = 9;
            this.lbMaKH.Text = "Mã khách hàng : ";
            // 
            // cbTaoMa
            // 
            this.cbTaoMa.AutoSize = true;
            this.cbTaoMa.Location = new System.Drawing.Point(300, 16);
            this.cbTaoMa.Name = "cbTaoMa";
            this.cbTaoMa.Size = new System.Drawing.Size(72, 17);
            this.cbTaoMa.TabIndex = 8;
            this.cbTaoMa.Text = "Tạo Mã ?";
            this.cbTaoMa.UseVisualStyleBackColor = true;
            this.cbTaoMa.CheckedChanged += new System.EventHandler(this.cbTaoMa_CheckedChanged);
            // 
            // tbMaNV
            // 
            this.tbMaNV.Location = new System.Drawing.Point(131, 125);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.ReadOnly = true;
            this.tbMaNV.Size = new System.Drawing.Size(143, 20);
            this.tbMaNV.TabIndex = 7;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(467, 128);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(35, 13);
            this.lbSDT.TabIndex = 6;
            this.lbSDT.Text = "SDT: ";
            // 
            // tbTenNV
            // 
            this.tbTenNV.Location = new System.Drawing.Point(131, 90);
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.ReadOnly = true;
            this.tbTenNV.Size = new System.Drawing.Size(143, 20);
            this.tbTenNV.TabIndex = 5;
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(30, 93);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(88, 13);
            this.lbTenNV.TabIndex = 4;
            this.lbTenNV.Text = "Tên Nhân Viên : ";
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Location = new System.Drawing.Point(30, 55);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(62, 13);
            this.lbNgay.TabIndex = 3;
            this.lbNgay.Text = "Ngày bán : ";
            // 
            // tbMaHD
            // 
            this.tbMaHD.Location = new System.Drawing.Point(131, 16);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(143, 20);
            this.tbMaHD.TabIndex = 1;
            // 
            // lbMaHoaDon
            // 
            this.lbMaHoaDon.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbMaHoaDon.AutoSize = true;
            this.lbMaHoaDon.Location = new System.Drawing.Point(30, 19);
            this.lbMaHoaDon.Name = "lbMaHoaDon";
            this.lbMaHoaDon.Size = new System.Drawing.Size(74, 13);
            this.lbMaHoaDon.TabIndex = 0;
            this.lbMaHoaDon.Text = "Mã hóa đơn : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTongTien);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbTamTinh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbTenSP2);
            this.groupBox2.Controls.Add(this.tbCK);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lbCK);
            this.groupBox2.Controls.Add(this.tbSL);
            this.groupBox2.Controls.Add(this.lbSL);
            this.groupBox2.Controls.Add(this.cbTenSP);
            this.groupBox2.Location = new System.Drawing.Point(28, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 165);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản Phẩm";
            // 
            // tbTamTinh
            // 
            this.tbTamTinh.Location = new System.Drawing.Point(250, 79);
            this.tbTamTinh.Name = "tbTamTinh";
            this.tbTamTinh.ReadOnly = true;
            this.tbTamTinh.Size = new System.Drawing.Size(101, 20);
            this.tbTamTinh.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tạm tính : ";
            // 
            // lbTenSP2
            // 
            this.lbTenSP2.AutoSize = true;
            this.lbTenSP2.Location = new System.Drawing.Point(20, 35);
            this.lbTenSP2.Name = "lbTenSP2";
            this.lbTenSP2.Size = new System.Drawing.Size(84, 13);
            this.lbTenSP2.TabIndex = 25;
            this.lbTenSP2.Text = "Tên Sản Phẩm :";
            // 
            // tbCK
            // 
            this.tbCK.Location = new System.Drawing.Point(110, 117);
            this.tbCK.Name = "tbCK";
            this.tbCK.Size = new System.Drawing.Size(70, 20);
            this.tbCK.TabIndex = 23;
            this.tbCK.Text = "0";
            this.tbCK.TextChanged += new System.EventHandler(this.tbCK_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbMaSp);
            this.groupBox3.Controls.Add(this.tbSLTon);
            this.groupBox3.Controls.Add(this.lbSLTon);
            this.groupBox3.Controls.Add(this.tbGiaBan);
            this.groupBox3.Controls.Add(this.tbTenSP);
            this.groupBox3.Controls.Add(this.lbGiaBan);
            this.groupBox3.Controls.Add(this.lbTenSP);
            this.groupBox3.Controls.Add(this.lbMaSP);
            this.groupBox3.Controls.Add(this.tbDonVi);
            this.groupBox3.Controls.Add(this.lbDonVi);
            this.groupBox3.Location = new System.Drawing.Point(357, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 150);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // tbMaSp
            // 
            this.tbMaSp.Location = new System.Drawing.Point(104, 37);
            this.tbMaSp.Name = "tbMaSp";
            this.tbMaSp.ReadOnly = true;
            this.tbMaSp.Size = new System.Drawing.Size(102, 20);
            this.tbMaSp.TabIndex = 22;
            // 
            // tbSLTon
            // 
            this.tbSLTon.Location = new System.Drawing.Point(307, 108);
            this.tbSLTon.Name = "tbSLTon";
            this.tbSLTon.ReadOnly = true;
            this.tbSLTon.Size = new System.Drawing.Size(83, 20);
            this.tbSLTon.TabIndex = 21;
            // 
            // lbSLTon
            // 
            this.lbSLTon.AutoSize = true;
            this.lbSLTon.Location = new System.Drawing.Point(228, 111);
            this.lbSLTon.Name = "lbSLTon";
            this.lbSLTon.Size = new System.Drawing.Size(73, 13);
            this.lbSLTon.TabIndex = 20;
            this.lbSLTon.Text = "Số lượng tồn :";
            // 
            // tbGiaBan
            // 
            this.tbGiaBan.Location = new System.Drawing.Point(307, 63);
            this.tbGiaBan.Name = "tbGiaBan";
            this.tbGiaBan.ReadOnly = true;
            this.tbGiaBan.Size = new System.Drawing.Size(83, 20);
            this.tbGiaBan.TabIndex = 19;
            // 
            // tbTenSP
            // 
            this.tbTenSP.Location = new System.Drawing.Point(104, 92);
            this.tbTenSP.Name = "tbTenSP";
            this.tbTenSP.ReadOnly = true;
            this.tbTenSP.Size = new System.Drawing.Size(102, 20);
            this.tbTenSP.TabIndex = 7;
            // 
            // lbGiaBan
            // 
            this.lbGiaBan.AutoSize = true;
            this.lbGiaBan.Location = new System.Drawing.Point(228, 66);
            this.lbGiaBan.Name = "lbGiaBan";
            this.lbGiaBan.Size = new System.Drawing.Size(50, 13);
            this.lbGiaBan.TabIndex = 18;
            this.lbGiaBan.Text = "Giá bán :";
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Location = new System.Drawing.Point(5, 95);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(84, 13);
            this.lbTenSP.TabIndex = 6;
            this.lbTenSP.Text = "Tên Sản Phẩm :";
            // 
            // lbMaSP
            // 
            this.lbMaSP.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.Location = new System.Drawing.Point(9, 40);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(80, 13);
            this.lbMaSP.TabIndex = 1;
            this.lbMaSP.Text = "Mã sản phẩm : ";
            // 
            // tbDonVi
            // 
            this.tbDonVi.Location = new System.Drawing.Point(307, 19);
            this.tbDonVi.Name = "tbDonVi";
            this.tbDonVi.ReadOnly = true;
            this.tbDonVi.Size = new System.Drawing.Size(83, 20);
            this.tbDonVi.TabIndex = 17;
            // 
            // lbDonVi
            // 
            this.lbDonVi.AutoSize = true;
            this.lbDonVi.Location = new System.Drawing.Point(228, 22);
            this.lbDonVi.Name = "lbDonVi";
            this.lbDonVi.Size = new System.Drawing.Size(44, 13);
            this.lbDonVi.TabIndex = 16;
            this.lbDonVi.Text = "Đơn vị :";
            // 
            // lbCK
            // 
            this.lbCK.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbCK.AutoSize = true;
            this.lbCK.Location = new System.Drawing.Point(20, 120);
            this.lbCK.Name = "lbCK";
            this.lbCK.Size = new System.Drawing.Size(88, 13);
            this.lbCK.TabIndex = 24;
            this.lbCK.Text = "Chiết Khấu (%) :  ";
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(110, 79);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(70, 20);
            this.tbSL.TabIndex = 9;
            this.tbSL.Text = "0";
            this.tbSL.TextChanged += new System.EventHandler(this.tbSL_TextChanged);
            // 
            // lbSL
            // 
            this.lbSL.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbSL.AutoSize = true;
            this.lbSL.Location = new System.Drawing.Point(20, 79);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(58, 13);
            this.lbSL.TabIndex = 22;
            this.lbSL.Text = "Số lượng : ";
            // 
            // cbTenSP
            // 
            this.cbTenSP.FormattingEnabled = true;
            this.cbTenSP.Location = new System.Drawing.Point(110, 32);
            this.cbTenSP.Name = "cbTenSP";
            this.cbTenSP.Size = new System.Drawing.Size(143, 21);
            this.cbTenSP.TabIndex = 3;
            this.cbTenSP.SelectedIndexChanged += new System.EventHandler(this.cbTenSP_SelectedIndexChanged);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(28, 634);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(119, 23);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(544, 634);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(119, 23);
            this.btnNhapLai.TabIndex = 6;
            this.btnNhapLai.Text = "Nhập Lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(688, 634);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm Vào Giỏ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(250, 117);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.ReadOnly = true;
            this.tbTongTien.Size = new System.Drawing.Size(101, 20);
            this.tbTongTien.TabIndex = 29;
            this.tbTongTien.TextChanged += new System.EventHandler(this.tbTongTien_TextChanged);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tổng tiền : ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 664);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.Label lbMaHoaDon;
        private System.Windows.Forms.CheckBox cbTaoMa;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbMaKH;
        private System.Windows.Forms.ComboBox cbTenKH;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbSLTon;
        private System.Windows.Forms.Label lbSLTon;
        private System.Windows.Forms.TextBox tbGiaBan;
        private System.Windows.Forms.Label lbGiaBan;
        private System.Windows.Forms.TextBox tbDonVi;
        private System.Windows.Forms.Label lbDonVi;
        private System.Windows.Forms.TextBox tbTenSP;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.ComboBox cbTenSP;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.TextBox tbCK;
        private System.Windows.Forms.Label lbCK;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.TextBox tbNgayBan;
        private Label lbTenSP2;
        private TextBox tbMaSp;
        private TextBox tbTamTinh;
        private Label label1;
        private Button btnAdd;
        private TextBox tbTongTien;
        private Label label2;
    }
}
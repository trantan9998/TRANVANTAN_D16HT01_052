namespace lab3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.gPhieuDatBao = new System.Windows.Forms.GroupBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteDB = new System.Windows.Forms.Button();
            this.btnUpdateDB = new System.Windows.Forms.Button();
            this.btnNewDB = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.cbSDT = new System.Windows.Forms.ComboBox();
            this.txtTenKH = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.Label();
            this.txttenkhachhang = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gChiTietDatBao = new System.Windows.Forms.GroupBox();
            this.dgvCTDB = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttentapchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtthangbd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtthangkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdongiathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtthanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudThangKT = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteTC = new System.Windows.Forms.Button();
            this.nudThangBD = new System.Windows.Forms.NumericUpDown();
            this.btnAddTC = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTapChi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bdPDB = new System.Windows.Forms.BindingSource(this.components);
            this.gPhieuDatBao.SuspendLayout();
            this.gChiTietDatBao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPDB)).BeginInit();
            this.SuspendLayout();
            // 
            // gPhieuDatBao
            // 
            this.gPhieuDatBao.Controls.Add(this.btnLast);
            this.gPhieuDatBao.Controls.Add(this.btnNext);
            this.gPhieuDatBao.Controls.Add(this.btnPrevious);
            this.gPhieuDatBao.Controls.Add(this.btnFirst);
            this.gPhieuDatBao.Controls.Add(this.btnCancel);
            this.gPhieuDatBao.Controls.Add(this.button5);
            this.gPhieuDatBao.Controls.Add(this.btnSave);
            this.gPhieuDatBao.Controls.Add(this.btnDeleteDB);
            this.gPhieuDatBao.Controls.Add(this.btnUpdateDB);
            this.gPhieuDatBao.Controls.Add(this.btnNewDB);
            this.gPhieuDatBao.Controls.Add(this.txtDiaChi);
            this.gPhieuDatBao.Controls.Add(this.dtNgayDat);
            this.gPhieuDatBao.Controls.Add(this.cbSDT);
            this.gPhieuDatBao.Controls.Add(this.txtTenKH);
            this.gPhieuDatBao.Controls.Add(this.label2);
            this.gPhieuDatBao.Controls.Add(this.label5);
            this.gPhieuDatBao.Controls.Add(this.label4);
            this.gPhieuDatBao.Controls.Add(this.txtSoPhieu);
            this.gPhieuDatBao.Controls.Add(this.txttenkhachhang);
            this.gPhieuDatBao.Controls.Add(this.textBox1);
            this.gPhieuDatBao.Location = new System.Drawing.Point(12, 80);
            this.gPhieuDatBao.Name = "gPhieuDatBao";
            this.gPhieuDatBao.Size = new System.Drawing.Size(770, 144);
            this.gPhieuDatBao.TabIndex = 0;
            this.gPhieuDatBao.TabStop = false;
            this.gPhieuDatBao.Text = "Phiếu đặt báo cáo";
            this.gPhieuDatBao.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(183, 115);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(52, 23);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = "||>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(125, 115);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(52, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(67, 115);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(52, 23);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(9, 115);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(52, 23);
            this.btnFirst.TabIndex = 6;
            this.btnFirst.Text = "<||";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCancel.Location = new System.Drawing.Point(662, 48);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button5.Location = new System.Drawing.Point(662, 88);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 34);
            this.button5.TabIndex = 5;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(662, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteDB.Location = new System.Drawing.Point(581, 88);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(75, 34);
            this.btnDeleteDB.TabIndex = 5;
            this.btnDeleteDB.Text = "Delete";
            this.btnDeleteDB.UseVisualStyleBackColor = false;
            this.btnDeleteDB.Click += new System.EventHandler(this.btnDeleteDB_Click);
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdateDB.Location = new System.Drawing.Point(581, 48);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(75, 34);
            this.btnUpdateDB.TabIndex = 5;
            this.btnUpdateDB.Text = "Update";
            this.btnUpdateDB.UseVisualStyleBackColor = false;
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // btnNewDB
            // 
            this.btnNewDB.Image = global::lab3.Properties.Resources.download;
            this.btnNewDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewDB.Location = new System.Drawing.Point(581, 13);
            this.btnNewDB.Name = "btnNewDB";
            this.btnNewDB.Size = new System.Drawing.Size(75, 29);
            this.btnNewDB.TabIndex = 5;
            this.btnNewDB.Text = "New";
            this.btnNewDB.UseVisualStyleBackColor = true;
            this.btnNewDB.Click += new System.EventHandler(this.btnNewDB_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(355, 60);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 51);
            this.txtDiaChi.TabIndex = 4;
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.Location = new System.Drawing.Point(355, 17);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(200, 20);
            this.dtNgayDat.TabIndex = 3;
            // 
            // cbSDT
            // 
            this.cbSDT.FormattingEnabled = true;
            this.cbSDT.Location = new System.Drawing.Point(100, 45);
            this.cbSDT.Name = "cbSDT";
            this.cbSDT.Size = new System.Drawing.Size(121, 21);
            this.cbSDT.TabIndex = 2;
            this.cbSDT.SelectedIndexChanged += new System.EventHandler(this.cbSDT_SelectedIndexChanged);
            // 
            // txtTenKH
            // 
            this.txtTenKH.AutoSize = true;
            this.txtTenKH.Location = new System.Drawing.Point(6, 81);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(86, 13);
            this.txtTenKH.TabIndex = 1;
            this.txtTenKH.Text = "Tên khách hàng";
            this.txtTenKH.Click += new System.EventHandler(this.txtTenKH_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm số điện thoại";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày đặt hàng:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.AutoSize = true;
            this.txtSoPhieu.Location = new System.Drawing.Point(6, 26);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(67, 13);
            this.txtSoPhieu.TabIndex = 1;
            this.txtSoPhieu.Text = "Tìm số phiếu";
            // 
            // txttenkhachhang
            // 
            this.txttenkhachhang.Location = new System.Drawing.Point(100, 74);
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.Size = new System.Drawing.Size(121, 20);
            this.txttenkhachhang.TabIndex = 0;
            this.txttenkhachhang.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 0;
            // 
            // gChiTietDatBao
            // 
            this.gChiTietDatBao.Controls.Add(this.dgvCTDB);
            this.gChiTietDatBao.Controls.Add(this.nudThangKT);
            this.gChiTietDatBao.Controls.Add(this.btnDeleteTC);
            this.gChiTietDatBao.Controls.Add(this.nudThangBD);
            this.gChiTietDatBao.Controls.Add(this.btnAddTC);
            this.gChiTietDatBao.Controls.Add(this.nudSoLuong);
            this.gChiTietDatBao.Controls.Add(this.label10);
            this.gChiTietDatBao.Controls.Add(this.txtTong);
            this.gChiTietDatBao.Controls.Add(this.label9);
            this.gChiTietDatBao.Controls.Add(this.label7);
            this.gChiTietDatBao.Controls.Add(this.label8);
            this.gChiTietDatBao.Controls.Add(this.label6);
            this.gChiTietDatBao.Controls.Add(this.cbTapChi);
            this.gChiTietDatBao.Location = new System.Drawing.Point(12, 230);
            this.gChiTietDatBao.Name = "gChiTietDatBao";
            this.gChiTietDatBao.Size = new System.Drawing.Size(770, 292);
            this.gChiTietDatBao.TabIndex = 1;
            this.gChiTietDatBao.TabStop = false;
            this.gChiTietDatBao.Text = "Chi tiết đặt báo";
            this.gChiTietDatBao.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgvCTDB
            // 
            this.dgvCTDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.txttentapchi,
            this.txtthangbd,
            this.txtthangkt,
            this.txtsoluong,
            this.txtdongiathang,
            this.txtthanhtien});
            this.dgvCTDB.Location = new System.Drawing.Point(9, 116);
            this.dgvCTDB.Name = "dgvCTDB";
            this.dgvCTDB.Size = new System.Drawing.Size(729, 150);
            this.dgvCTDB.TabIndex = 6;
            this.dgvCTDB.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCTDB_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // txttentapchi
            // 
            this.txttentapchi.DataPropertyName = "TenTC";
            this.txttentapchi.HeaderText = "Tên tạp chí";
            this.txttentapchi.Name = "txttentapchi";
            // 
            // txtthangbd
            // 
            this.txtthangbd.DataPropertyName = "ThangBD";
            this.txtthangbd.HeaderText = "Tháng Bắt Đầu";
            this.txtthangbd.Name = "txtthangbd";
            // 
            // txtthangkt
            // 
            this.txtthangkt.DataPropertyName = "ThangKT";
            this.txtthangkt.HeaderText = "Tháng kết thúc";
            this.txtthangkt.Name = "txtthangkt";
            // 
            // txtsoluong
            // 
            this.txtsoluong.DataPropertyName = "SoLuong";
            this.txtsoluong.HeaderText = "Số Lượng ";
            this.txtsoluong.Name = "txtsoluong";
            // 
            // txtdongiathang
            // 
            this.txtdongiathang.DataPropertyName = "DonGiaThang";
            this.txtdongiathang.HeaderText = "Đơn giá tháng";
            this.txtdongiathang.Name = "txtdongiathang";
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.DataPropertyName = "Thanhtien";
            this.txtthanhtien.HeaderText = "Thành Tiền";
            this.txtthanhtien.Name = "txtthanhtien";
            // 
            // nudThangKT
            // 
            this.nudThangKT.Location = new System.Drawing.Point(633, 26);
            this.nudThangKT.Name = "nudThangKT";
            this.nudThangKT.Size = new System.Drawing.Size(67, 20);
            this.nudThangKT.TabIndex = 4;
            // 
            // btnDeleteTC
            // 
            this.btnDeleteTC.BackColor = System.Drawing.Color.Aqua;
            this.btnDeleteTC.Location = new System.Drawing.Point(663, 76);
            this.btnDeleteTC.Name = "btnDeleteTC";
            this.btnDeleteTC.Size = new System.Drawing.Size(75, 34);
            this.btnDeleteTC.TabIndex = 5;
            this.btnDeleteTC.Text = "Delete";
            this.btnDeleteTC.UseVisualStyleBackColor = false;
            this.btnDeleteTC.Click += new System.EventHandler(this.btnDeleteTC_Click);
            // 
            // nudThangBD
            // 
            this.nudThangBD.Location = new System.Drawing.Point(457, 21);
            this.nudThangBD.Name = "nudThangBD";
            this.nudThangBD.Size = new System.Drawing.Size(67, 20);
            this.nudThangBD.TabIndex = 4;
            // 
            // btnAddTC
            // 
            this.btnAddTC.BackColor = System.Drawing.Color.Yellow;
            this.btnAddTC.Location = new System.Drawing.Point(570, 76);
            this.btnAddTC.Name = "btnAddTC";
            this.btnAddTC.Size = new System.Drawing.Size(86, 34);
            this.btnAddTC.TabIndex = 5;
            this.btnAddTC.Text = "Add";
            this.btnAddTC.UseVisualStyleBackColor = false;
            this.btnAddTC.Click += new System.EventHandler(this.btnAddTC_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(303, 23);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(67, 20);
            this.nudSoLuong.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(544, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tháng kết thúc:";
            this.label10.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(100, 56);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(121, 20);
            this.txtTong.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tháng BĐ";
            this.label9.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tổng tiền:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Số lượng:";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tìm tên tạp chí";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbTapChi
            // 
            this.cbTapChi.FormattingEnabled = true;
            this.cbTapChi.Location = new System.Drawing.Point(100, 29);
            this.cbTapChi.Name = "cbTapChi";
            this.cbTapChi.Size = new System.Drawing.Size(121, 21);
            this.cbTapChi.TabIndex = 2;
            this.cbTapChi.SelectedIndexChanged += new System.EventHandler(this.cbTapChi_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(18, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 27);
            this.label11.TabIndex = 2;
            this.label11.Text = "ĐẶT THEO BÁO CÁO";
            // 
            // bdPDB
            // 
            this.bdPDB.CurrentChanged += new System.EventHandler(this.bdPDB_CurrentChanged);
            this.bdPDB.PositionChanged += new System.EventHandler(this.bdPDB_PositionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gChiTietDatBao);
            this.Controls.Add(this.gPhieuDatBao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gPhieuDatBao.ResumeLayout(false);
            this.gPhieuDatBao.PerformLayout();
            this.gChiTietDatBao.ResumeLayout(false);
            this.gChiTietDatBao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdPDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gPhieuDatBao;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteDB;
        private System.Windows.Forms.Button btnUpdateDB;
        private System.Windows.Forms.Button btnNewDB;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private System.Windows.Forms.ComboBox cbSDT;
        private System.Windows.Forms.Label txtTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtSoPhieu;
        private System.Windows.Forms.TextBox txttenkhachhang;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gChiTietDatBao;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTapChi;
        private System.Windows.Forms.DataGridView dgvCTDB;
        private System.Windows.Forms.NumericUpDown nudThangKT;
        private System.Windows.Forms.Button btnDeleteTC;
        private System.Windows.Forms.NumericUpDown nudThangBD;
        private System.Windows.Forms.Button btnAddTC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.BindingSource bdPDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn txttentapchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtthangbd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtthangkt;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtsoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtdongiathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtthanhtien;
    }
}


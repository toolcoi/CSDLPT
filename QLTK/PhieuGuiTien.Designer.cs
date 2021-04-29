
namespace QLTK
{
    partial class PhieuGuiTien
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
            this.dICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kyHan_num_PGT_cbb = new System.Windows.Forms.ComboBox();
            this.dICHVUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.laiSuat_PGT_cbb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker_ngayGui_PGT = new System.Windows.Forms.DateTimePicker();
            this.maPhieu_PGT_tb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ghi_PGT_btn = new System.Windows.Forms.Button();
            this.xoaphieu_PGT_btn = new System.Windows.Forms.Button();
            this.lapphieumoi_PGT_btn = new System.Windows.Forms.Button();
            this.lAISUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soTienGui_PGT_tb = new System.Windows.Forms.TextBox();
            this.thoat_PGT_btn = new System.Windows.Forms.Button();
            this.tenDV_PGT_cbb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maGDV_PGT_cbb = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmnd_PGT_tb = new System.Windows.Forms.TextBox();
            this.diachi_PGT_tb = new System.Windows.Forms.TextBox();
            this.tenKH_PGT_tb = new System.Windows.Forms.TextBox();
            this.maKH_PGT_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.denHan_PGT_tb = new System.Windows.Forms.TextBox();
            this.comboBox_maDV_PGT = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAISUATBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dICHVUBindingSource
            // 
            this.dICHVUBindingSource.DataMember = "DICHVU";
            // 
            // kyHan_num_PGT_cbb
            // 
            this.kyHan_num_PGT_cbb.DataSource = this.dICHVUBindingSource;
            this.kyHan_num_PGT_cbb.DisplayMember = "KYHAN";
            this.kyHan_num_PGT_cbb.FormattingEnabled = true;
            this.kyHan_num_PGT_cbb.Location = new System.Drawing.Point(68, 48);
            this.kyHan_num_PGT_cbb.Name = "kyHan_num_PGT_cbb";
            this.kyHan_num_PGT_cbb.Size = new System.Drawing.Size(74, 24);
            this.kyHan_num_PGT_cbb.TabIndex = 27;
            this.kyHan_num_PGT_cbb.ValueMember = "KYHAN";
            // 
            // dICHVUBindingSource1
            // 
            this.dICHVUBindingSource1.DataMember = "DICHVU";
            // 
            // laiSuat_PGT_cbb
            // 
            this.laiSuat_PGT_cbb.DisplayMember = "LAISUAT";
            this.laiSuat_PGT_cbb.FormattingEnabled = true;
            this.laiSuat_PGT_cbb.Location = new System.Drawing.Point(216, 49);
            this.laiSuat_PGT_cbb.Margin = new System.Windows.Forms.Padding(1);
            this.laiSuat_PGT_cbb.Name = "laiSuat_PGT_cbb";
            this.laiSuat_PGT_cbb.Size = new System.Drawing.Size(122, 24);
            this.laiSuat_PGT_cbb.TabIndex = 28;
            this.laiSuat_PGT_cbb.ValueMember = "LAISUAT";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.CausesValidation = false;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(691, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 44);
            this.button1.TabIndex = 37;
            this.button1.Text = "DSKH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker_ngayGui_PGT
            // 
            this.dateTimePicker_ngayGui_PGT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ngayGui_PGT.Location = new System.Drawing.Point(505, 127);
            this.dateTimePicker_ngayGui_PGT.Margin = new System.Windows.Forms.Padding(1);
            this.dateTimePicker_ngayGui_PGT.Name = "dateTimePicker_ngayGui_PGT";
            this.dateTimePicker_ngayGui_PGT.Size = new System.Drawing.Size(164, 22);
            this.dateTimePicker_ngayGui_PGT.TabIndex = 36;
            // 
            // maPhieu_PGT_tb
            // 
            this.maPhieu_PGT_tb.Location = new System.Drawing.Point(185, 127);
            this.maPhieu_PGT_tb.Name = "maPhieu_PGT_tb";
            this.maPhieu_PGT_tb.Size = new System.Drawing.Size(170, 22);
            this.maPhieu_PGT_tb.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(243, 500);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 19);
            this.label14.TabIndex = 29;
            this.label14.Text = "Số tiền gửi";
            // 
            // ghi_PGT_btn
            // 
            this.ghi_PGT_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ghi_PGT_btn.CausesValidation = false;
            this.ghi_PGT_btn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghi_PGT_btn.Location = new System.Drawing.Point(691, 268);
            this.ghi_PGT_btn.Name = "ghi_PGT_btn";
            this.ghi_PGT_btn.Size = new System.Drawing.Size(141, 44);
            this.ghi_PGT_btn.TabIndex = 32;
            this.ghi_PGT_btn.Text = "Ghi";
            this.ghi_PGT_btn.UseVisualStyleBackColor = false;
            this.ghi_PGT_btn.Click += new System.EventHandler(this.ghi_PGT_btn_Click);
            // 
            // xoaphieu_PGT_btn
            // 
            this.xoaphieu_PGT_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xoaphieu_PGT_btn.CausesValidation = false;
            this.xoaphieu_PGT_btn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaphieu_PGT_btn.Location = new System.Drawing.Point(691, 218);
            this.xoaphieu_PGT_btn.Name = "xoaphieu_PGT_btn";
            this.xoaphieu_PGT_btn.Size = new System.Drawing.Size(141, 44);
            this.xoaphieu_PGT_btn.TabIndex = 31;
            this.xoaphieu_PGT_btn.Text = "Xóa Phiếu";
            this.xoaphieu_PGT_btn.UseVisualStyleBackColor = false;
            // 
            // lapphieumoi_PGT_btn
            // 
            this.lapphieumoi_PGT_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lapphieumoi_PGT_btn.CausesValidation = false;
            this.lapphieumoi_PGT_btn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapphieumoi_PGT_btn.Location = new System.Drawing.Point(691, 165);
            this.lapphieumoi_PGT_btn.Name = "lapphieumoi_PGT_btn";
            this.lapphieumoi_PGT_btn.Size = new System.Drawing.Size(141, 44);
            this.lapphieumoi_PGT_btn.TabIndex = 30;
            this.lapphieumoi_PGT_btn.Text = "Lập phiếu mới";
            this.lapphieumoi_PGT_btn.UseVisualStyleBackColor = false;
            this.lapphieumoi_PGT_btn.Click += new System.EventHandler(this.lapphieumoi_PGT_btn_Click);
            // 
            // lAISUATBindingSource
            // 
            this.lAISUATBindingSource.DataMember = "LAISUAT";
            // 
            // soTienGui_PGT_tb
            // 
            this.soTienGui_PGT_tb.Location = new System.Drawing.Point(328, 497);
            this.soTienGui_PGT_tb.Name = "soTienGui_PGT_tb";
            this.soTienGui_PGT_tb.Size = new System.Drawing.Size(306, 22);
            this.soTienGui_PGT_tb.TabIndex = 35;
            // 
            // thoat_PGT_btn
            // 
            this.thoat_PGT_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.thoat_PGT_btn.CausesValidation = false;
            this.thoat_PGT_btn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat_PGT_btn.Location = new System.Drawing.Point(691, 330);
            this.thoat_PGT_btn.Name = "thoat_PGT_btn";
            this.thoat_PGT_btn.Size = new System.Drawing.Size(141, 44);
            this.thoat_PGT_btn.TabIndex = 33;
            this.thoat_PGT_btn.Text = "Thoát";
            this.thoat_PGT_btn.UseVisualStyleBackColor = false;
            this.thoat_PGT_btn.Click += new System.EventHandler(this.thoat_PGT_btn_Click);
            // 
            // tenDV_PGT_cbb
            // 
            this.tenDV_PGT_cbb.DataSource = this.dICHVUBindingSource;
            this.tenDV_PGT_cbb.DisplayMember = "TENDV";
            this.tenDV_PGT_cbb.FormattingEnabled = true;
            this.tenDV_PGT_cbb.Location = new System.Drawing.Point(216, 15);
            this.tenDV_PGT_cbb.Name = "tenDV_PGT_cbb";
            this.tenDV_PGT_cbb.Size = new System.Drawing.Size(402, 24);
            this.tenDV_PGT_cbb.TabIndex = 26;
            this.tenDV_PGT_cbb.ValueMember = "TENDV";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maGDV_PGT_cbb);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cmnd_PGT_tb);
            this.groupBox1.Controls.Add(this.diachi_PGT_tb);
            this.groupBox1.Controls.Add(this.tenKH_PGT_tb);
            this.groupBox1.Controls.Add(this.maKH_PGT_tb);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(53, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 220);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // maGDV_PGT_cbb
            // 
            this.maGDV_PGT_cbb.FormattingEnabled = true;
            this.maGDV_PGT_cbb.Location = new System.Drawing.Point(452, 34);
            this.maGDV_PGT_cbb.Margin = new System.Windows.Forms.Padding(1);
            this.maGDV_PGT_cbb.Name = "maGDV_PGT_cbb";
            this.maGDV_PGT_cbb.Size = new System.Drawing.Size(164, 24);
            this.maGDV_PGT_cbb.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(357, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 19);
            this.label15.TabIndex = 21;
            this.label15.Text = "Mã GDV:";
            // 
            // cmnd_PGT_tb
            // 
            this.cmnd_PGT_tb.Location = new System.Drawing.Point(132, 153);
            this.cmnd_PGT_tb.Name = "cmnd_PGT_tb";
            this.cmnd_PGT_tb.Size = new System.Drawing.Size(206, 22);
            this.cmnd_PGT_tb.TabIndex = 20;
            // 
            // diachi_PGT_tb
            // 
            this.diachi_PGT_tb.Location = new System.Drawing.Point(132, 111);
            this.diachi_PGT_tb.Name = "diachi_PGT_tb";
            this.diachi_PGT_tb.Size = new System.Drawing.Size(484, 22);
            this.diachi_PGT_tb.TabIndex = 17;
            // 
            // tenKH_PGT_tb
            // 
            this.tenKH_PGT_tb.Location = new System.Drawing.Point(132, 75);
            this.tenKH_PGT_tb.Name = "tenKH_PGT_tb";
            this.tenKH_PGT_tb.Size = new System.Drawing.Size(484, 22);
            this.tenKH_PGT_tb.TabIndex = 16;
            // 
            // maKH_PGT_tb
            // 
            this.maKH_PGT_tb.Location = new System.Drawing.Point(132, 35);
            this.maKH_PGT_tb.Name = "maKH_PGT_tb";
            this.maKH_PGT_tb.Size = new System.Drawing.Size(206, 22);
            this.maKH_PGT_tb.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số CMND:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ tên KH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã KH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ngày gửi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Số phiếu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 57);
            this.label1.TabIndex = 24;
            this.label1.Text = "Phiếu Gửi tiền";
            // 
            // denHan_PGT_tb
            // 
            this.denHan_PGT_tb.Location = new System.Drawing.Point(452, 49);
            this.denHan_PGT_tb.Name = "denHan_PGT_tb";
            this.denHan_PGT_tb.Size = new System.Drawing.Size(166, 22);
            this.denHan_PGT_tb.TabIndex = 25;
            // 
            // comboBox_maDV_PGT
            // 
            this.comboBox_maDV_PGT.DataSource = this.dICHVUBindingSource;
            this.comboBox_maDV_PGT.DisplayMember = "MADV";
            this.comboBox_maDV_PGT.FormattingEnabled = true;
            this.comboBox_maDV_PGT.Location = new System.Drawing.Point(68, 15);
            this.comboBox_maDV_PGT.Name = "comboBox_maDV_PGT";
            this.comboBox_maDV_PGT.Size = new System.Drawing.Size(74, 24);
            this.comboBox_maDV_PGT.TabIndex = 23;
            this.comboBox_maDV_PGT.ValueMember = "MADV";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(349, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 19);
            this.label11.TabIndex = 7;
            this.label11.Text = "Ngày đến hạn:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(148, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Lãi suất:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(148, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tên DV:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Kỳ hạn:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Mã DV:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.laiSuat_PGT_cbb);
            this.groupBox2.Controls.Add(this.kyHan_num_PGT_cbb);
            this.groupBox2.Controls.Add(this.tenDV_PGT_cbb);
            this.groupBox2.Controls.Add(this.denHan_PGT_tb);
            this.groupBox2.Controls.Add(this.comboBox_maDV_PGT);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(53, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(622, 88);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // PhieuGuiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker_ngayGui_PGT);
            this.Controls.Add(this.maPhieu_PGT_tb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ghi_PGT_btn);
            this.Controls.Add(this.xoaphieu_PGT_btn);
            this.Controls.Add(this.lapphieumoi_PGT_btn);
            this.Controls.Add(this.soTienGui_PGT_tb);
            this.Controls.Add(this.thoat_PGT_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "PhieuGuiTien";
            this.Text = "PhieuGuiTien";
            this.Load += new System.EventHandler(this.PhieuGuiTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lAISUATBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dICHVUBindingSource;
        private System.Windows.Forms.ComboBox kyHan_num_PGT_cbb;
        private System.Windows.Forms.BindingSource dICHVUBindingSource1;
        private System.Windows.Forms.ComboBox laiSuat_PGT_cbb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngayGui_PGT;
        private System.Windows.Forms.TextBox maPhieu_PGT_tb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ghi_PGT_btn;
        private System.Windows.Forms.Button xoaphieu_PGT_btn;
        private System.Windows.Forms.Button lapphieumoi_PGT_btn;
        private System.Windows.Forms.BindingSource lAISUATBindingSource;
        private System.Windows.Forms.TextBox soTienGui_PGT_tb;
        private System.Windows.Forms.Button thoat_PGT_btn;
        private System.Windows.Forms.ComboBox tenDV_PGT_cbb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox maGDV_PGT_cbb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox cmnd_PGT_tb;
        private System.Windows.Forms.TextBox diachi_PGT_tb;
        private System.Windows.Forms.TextBox tenKH_PGT_tb;
        private System.Windows.Forms.TextBox maKH_PGT_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox denHan_PGT_tb;
        private System.Windows.Forms.ComboBox comboBox_maDV_PGT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}